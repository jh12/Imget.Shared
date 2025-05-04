namespace Imget.Shared.Message.Event;

public class ImageTagsAcquired : ImageEventBase
{
    public required string[] Tags { get; set; }

    public ImageTagsAcquired()
    {
    }

    public ImageTagsAcquired(string sourceSystem, string imageId, string[] tags) : base(sourceSystem, imageId)
    {
        Tags = tags;
    }
}
