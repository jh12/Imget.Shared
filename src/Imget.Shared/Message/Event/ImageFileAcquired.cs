namespace Imget.Shared.Message.Event;

public class ImageFileAcquired : ImageEventBase
{
    public required string ImageAttachment { get; set; }

    public ImageFileAcquired()
    {
    }

    public ImageFileAcquired(string sourceSystem, string imageId, string imageAttachment) : base(sourceSystem, imageId)
    {
        ImageAttachment = imageAttachment;
    }
}
