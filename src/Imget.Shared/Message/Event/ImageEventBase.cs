namespace Imget.Shared.Message.Event;

public abstract class ImageEventBase
{
    public string SourceSystem { get; init; }
    public string ImageId { get; init; }

    protected ImageEventBase(string sourceSystem, string imageId)
    {
        SourceSystem = sourceSystem;
        ImageId = imageId;
    }
}
