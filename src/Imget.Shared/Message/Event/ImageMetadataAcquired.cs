using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class ImageMetadataAcquired : ImageEventBase
{
    public string? Title { get; init; }
    public string? Description { get; init; }
    public string? Creator { get; init; }

    public DateTime CreatedAt { get; init; }

    [JsonConstructor]
    public ImageMetadataAcquired(string sourceSystem, string imageId, string? title, string? description, string? creator, DateTime createdAt) : base(sourceSystem, imageId)
    {
        Title = title;
        Description = description;
        Creator = creator;
        CreatedAt = createdAt;
    }
}
