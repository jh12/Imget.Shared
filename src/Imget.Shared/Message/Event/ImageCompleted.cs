using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class ImageCompleted : ImageEventBase
{
    [JsonConstructor]
    public ImageCompleted(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
