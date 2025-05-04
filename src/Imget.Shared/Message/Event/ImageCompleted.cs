namespace Imget.Shared.Message.Event;

public class ImageCompleted : ImageEventBase
{
    public ImageCompleted()
    {
    }

    public ImageCompleted(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
