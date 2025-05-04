namespace Imget.Shared.Message.Event;

public class ImageThumbnailAcquired : ImageEventBase
{
    public required string ThumbnailAttachment { get; set; }
}
