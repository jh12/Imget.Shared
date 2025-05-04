using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class ImageThumbnailAcquired : ImageEventBase
{
    public required string ThumbnailAttachment { get; init; }

    [JsonConstructor]
    public ImageThumbnailAcquired(string sourceSystem, string imageId, string thumbnailAttachment) : base(sourceSystem, imageId)
    {
        ThumbnailAttachment = thumbnailAttachment;
    }
}
