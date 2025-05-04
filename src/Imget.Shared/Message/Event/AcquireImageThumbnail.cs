using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class AcquireImageThumbnail : ImageEventBase
{
    [JsonConstructor]
    public AcquireImageThumbnail(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
