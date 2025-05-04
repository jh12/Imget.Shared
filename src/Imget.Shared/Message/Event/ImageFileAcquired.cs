using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class ImageFileAcquired : ImageEventBase
{
    public required string ImageAttachment { get; init; }

    [JsonConstructor]
    public ImageFileAcquired(string sourceSystem, string imageId, string imageAttachment) : base(sourceSystem, imageId)
    {
        ImageAttachment = imageAttachment;
    }
}
