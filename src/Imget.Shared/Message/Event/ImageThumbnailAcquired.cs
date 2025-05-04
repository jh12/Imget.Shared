namespace Imget.Shared.Message.Event;

public class ImageThumbnailAcquired : ImageEventBase
{
    public required string ThumbnailAttachment { get; set; }

    public ImageThumbnailAcquired()
    {
    }

    public ImageThumbnailAcquired(string sourceSystem, string imageId, string thumbnailAttachment) : base(sourceSystem, imageId)
    {
        ThumbnailAttachment = thumbnailAttachment;
    }
}
