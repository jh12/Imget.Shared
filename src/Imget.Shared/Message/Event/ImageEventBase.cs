namespace Imget.Shared.Message.Event;

public abstract class ImageEventBase
{
    public required string SourceSystem { get; set; }
    public required string ImageId { get; set; }

    protected ImageEventBase()
    {
    }

    protected ImageEventBase(string sourceSystem, string imageId)
    {
        SourceSystem = sourceSystem;
        ImageId = imageId;
    }
}
