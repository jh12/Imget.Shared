using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class ImageFound : ImageEventBase
{
    [JsonConstructor]
    public ImageFound(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
