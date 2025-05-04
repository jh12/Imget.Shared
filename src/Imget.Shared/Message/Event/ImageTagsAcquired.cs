namespace Imget.Shared.Message.Event;

public class ImageTagsAcquired : ImageEventBase
{
    public required string[] Tags { get; set; }
}
