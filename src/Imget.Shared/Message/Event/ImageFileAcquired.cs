namespace Imget.Shared.Message.Event;

public class ImageFileAcquired : ImageEventBase
{
    public required string ImageAttachment { get; set; }
}
