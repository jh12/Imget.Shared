namespace Imget.Shared.Message.Event;

public class ImageFound : ImageEventBase
{
    public ImageFound()
    {
    }

    public ImageFound(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
