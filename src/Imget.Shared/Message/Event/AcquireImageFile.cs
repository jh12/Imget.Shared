using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class AcquireImageFile : ImageEventBase
{
    [JsonConstructor]
    public AcquireImageFile(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
