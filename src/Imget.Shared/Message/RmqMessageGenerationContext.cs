using System.Text.Json.Serialization;
using Imget.Shared.Message.Event;
using Imget.Shared.Message.Request;
using Imget.Shared.Message.Response;

namespace Imget.Shared.Message;

// Events
[JsonSerializable(typeof(ImageProcessed))]
[JsonSerializable(typeof(ImageDiscovered))]

// Requests
[JsonSerializable(typeof(RequestBase))]
[JsonSerializable(typeof(TaggingRequest))]

// Responses
[JsonSerializable(typeof(ResponseBase))]
[JsonSerializable(typeof(TaggingResponse))]
public partial class RmqMessageGenerationContext : JsonSerializerContext
{

}
