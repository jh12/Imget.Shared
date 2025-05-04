namespace Imget.Shared.Message.Event;

public class AcquireImageThumbnail : ImageEventBase
{
    public AcquireImageThumbnail()
    {
    }

    public AcquireImageThumbnail(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
