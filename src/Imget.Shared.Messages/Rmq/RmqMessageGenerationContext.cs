using System.Text.Json.Serialization;
using Imget.Shared.Messages.Rmq.Request;
using Imget.Shared.Messages.Rmq.Response;

namespace Imget.Shared.Messages.Rmq;

[JsonSerializable(typeof(RequestBase))]
[JsonSerializable(typeof(TaggingRequest))]

[JsonSerializable(typeof(ResponseBase))]
[JsonSerializable(typeof(TaggingResponse))]
public partial class RmqMessageGenerationContext : JsonSerializerContext
{

}
