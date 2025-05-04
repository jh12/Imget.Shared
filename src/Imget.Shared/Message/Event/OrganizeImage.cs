namespace Imget.Shared.Message.Event;

public class OrganizeImage : ImageEventBase
{
    public OrganizeImage()
    {
    }

    public OrganizeImage(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
