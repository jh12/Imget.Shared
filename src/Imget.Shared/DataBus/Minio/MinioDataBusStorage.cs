using Imget.Shared.Configuration;
using Microsoft.IO;
using Minio;
using Minio.DataModel.Args;
using Rebus.DataBus;

namespace Imget.Shared.DataBus.Minio;

public sealed class MinioDataBusStorage : IDataBusStorage, IDataBusStorageManagement, IDisposable
{
    private readonly IMinioClient _client;
    private readonly string _bucketName;
    private readonly string _prefix;
    private readonly RecyclableMemoryStreamManager _memoryManager = new();

    public MinioDataBusStorage(MinioDataBusConfig busConfig)
    {
        _client = new MinioClient()
            .WithEndpoint(busConfig.Endpoint)
            .WithCredentials(busConfig.AccessKey, busConfig.SecretKey)
            .Build();

        _bucketName = busConfig.Bucket;
        _prefix = busConfig.Prefix;
    }

    public async Task Save(string id, Stream source, Dictionary<string, string>? metadata = null)
    {
        await using Stream stream = _memoryManager.GetStream();
        await source.CopyToAsync(stream);

        stream.Position = 0;

        var args = new PutObjectArgs()
            .WithBucket(_bucketName)
            .WithObject(GetFullPath(id))
            .WithStreamData(stream)
            .WithObjectSize(stream.Length);

        await _client.PutObjectAsync(args);
    }

    public async Task<Stream> Read(string id)
    {
        Stream resultStream = _memoryManager.GetStream();

        var args = new GetObjectArgs()
            .WithBucket(_bucketName)
            .WithObject(GetFullPath(id))
            .WithCallbackStream((stream) =>
            {
                stream.CopyTo(resultStream);
                resultStream.Position = 0;
            });

        await _client.GetObjectAsync(args);

        return resultStream;
    }

    public async Task<Dictionary<string, string>> ReadMetadata(string id)
    {
        var args = new StatObjectArgs()
            .WithBucket(_bucketName)
            .WithObject(GetFullPath(id));

        var objectStat = await _client.StatObjectAsync(args);
        var metadata = objectStat.MetaData.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        metadata[MetadataKeys.Length] = objectStat.Size.ToString();

        return metadata;
    }

    public async Task Delete(string id)
    {
        var args = new RemoveObjectArgs()
            .WithBucket(_bucketName)
            .WithObject(GetFullPath(id));

        await _client.RemoveObjectAsync(args);
    }

    public IEnumerable<string> Query(TimeRange? readTime = null, TimeRange? saveTime = null)
    {
        throw new NotImplementedException();
    }

    private string GetFullPath(string id)
    {
        return $"{_prefix}/{id}";
    }

    public void Dispose()
    {
        _client.Dispose();
    }
}
