namespace Imget.Shared.Message.Event;

public class ImageMetadataAcquired : ImageEventBase
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Creator { get; set; }

    public DateTime CreatedAt { get; set; }

    public ImageMetadataAcquired()
    {
    }

    public ImageMetadataAcquired(string sourceSystem, string imageId, string? title, string? description, string? creator, DateTime createdAt) : base(sourceSystem, imageId)
    {
        Title = title;
        Description = description;
        Creator = creator;
        CreatedAt = createdAt;
    }
}
