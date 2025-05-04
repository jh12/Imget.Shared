using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class AcquireImageTags : ImageEventBase
{
    [JsonConstructor]
    public AcquireImageTags(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
