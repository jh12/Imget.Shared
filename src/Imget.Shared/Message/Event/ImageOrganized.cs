using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class ImageOrganized : ImageEventBase
{
    [JsonConstructor]
    public ImageOrganized(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
