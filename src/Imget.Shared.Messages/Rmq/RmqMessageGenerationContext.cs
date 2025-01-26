using System.Text.Json.Serialization;
using Imget.Shared.Messages.Rmq.Event;
using Imget.Shared.Messages.Rmq.Request;
using Imget.Shared.Messages.Rmq.Response;

namespace Imget.Shared.Messages.Rmq;

// Events
[JsonSerializable(typeof(ImageProcessed))]

// Requests
[JsonSerializable(typeof(RequestBase))]
[JsonSerializable(typeof(TaggingRequest))]

// Responses
[JsonSerializable(typeof(ResponseBase))]
[JsonSerializable(typeof(TaggingResponse))]
public partial class RmqMessageGenerationContext : JsonSerializerContext
{

}
