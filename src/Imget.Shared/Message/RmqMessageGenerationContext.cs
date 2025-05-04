using System.Text.Json.Serialization;
using Imget.Shared.Message.Event;
using Imget.Shared.Message.Request;
using Imget.Shared.Message.Response;

namespace Imget.Shared.Message;

// Events
[JsonSerializable(typeof(ImageProcessed))]
[JsonSerializable(typeof(ImageDiscovered))]

[JsonSerializable(typeof(AcquireImageFile))]
[JsonSerializable(typeof(AcquireImageMetadata))]
[JsonSerializable(typeof(AcquireImageTags))]
[JsonSerializable(typeof(AcquireImageThumbnail))]
[JsonSerializable(typeof(ImageCompleted))]
[JsonSerializable(typeof(ImageEventBase))]
[JsonSerializable(typeof(ImageFileAcquired))]
[JsonSerializable(typeof(ImageFound))]
[JsonSerializable(typeof(ImageMetadataAcquired))]
[JsonSerializable(typeof(ImageOrganized))]
[JsonSerializable(typeof(ImageTagsAcquired))]
[JsonSerializable(typeof(ImageThumbnailAcquired))]
[JsonSerializable(typeof(OrganizeImage))]

// Requests
[JsonSerializable(typeof(RequestBase))]
[JsonSerializable(typeof(TaggingRequest))]

// Responses
[JsonSerializable(typeof(ResponseBase))]
[JsonSerializable(typeof(TaggingResponse))]
public partial class RmqMessageGenerationContext : JsonSerializerContext
{

}
