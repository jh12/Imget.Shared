namespace Imget.Shared.Message.Event;

public class ImageMetadataAcquired : ImageEventBase
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Creator { get; set; }

    public DateTime CreatedAt { get; set; }
}
