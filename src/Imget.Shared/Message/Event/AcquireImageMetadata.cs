using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class AcquireImageMetadata : ImageEventBase
{
    [JsonConstructor]
    public AcquireImageMetadata(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
