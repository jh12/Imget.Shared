namespace Imget.Shared.Message.Event;

public abstract class ImageEventBase
{
    public required string SourceSystem { get; set; }
    public required string ImageId { get; set; }
}
