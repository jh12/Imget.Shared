namespace Imget.Shared.Message.Event;

public class AcquireImageFile : ImageEventBase
{
    public AcquireImageFile()
    {
    }

    public AcquireImageFile(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
