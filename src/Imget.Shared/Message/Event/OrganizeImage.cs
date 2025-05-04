using System.Text.Json.Serialization;

namespace Imget.Shared.Message.Event;

public class OrganizeImage : ImageEventBase
{
    [JsonConstructor]
    public OrganizeImage(string sourceSystem, string imageId) : base(sourceSystem, imageId)
    {
    }
}
