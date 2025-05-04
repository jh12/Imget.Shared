namespace Imget.Shared.Message.Event;

public class AcquireImageMetadata : ImageEventBase
{
    public AcquireImageMetadata()
    {
    }

    public AcquireImageMetadata(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
