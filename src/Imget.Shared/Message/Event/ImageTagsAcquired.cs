using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class ImageTagsAcquired : ImageEventBase
{
    public string[] Tags { get; init; }

    [JsonConstructor]
    public ImageTagsAcquired(string sourceSystem, string imageId, string[] tags) : base(sourceSystem, imageId)
    {
        Tags = tags;
    }
}
