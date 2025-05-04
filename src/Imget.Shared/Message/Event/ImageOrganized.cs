namespace Imget.Shared.Message.Event;

public class ImageOrganized : ImageEventBase
{
    public ImageOrganized()
    {
    }

    public ImageOrganized(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
