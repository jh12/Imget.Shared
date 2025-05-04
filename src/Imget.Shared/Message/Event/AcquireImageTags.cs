namespace Imget.Shared.Message.Event;

public class AcquireImageTags : ImageEventBase
{
    public AcquireImageTags()
    {
    }

    public AcquireImageTags(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
