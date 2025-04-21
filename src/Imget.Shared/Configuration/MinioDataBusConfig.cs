namespace Imget.Shared.Configuration;

public sealed record MinioDataBusConfig
(
    string Endpoint,
    string AccessKey,
    string SecretKey,
    string Bucket
);
