namespace Imget.Shared.Message.Response;

public sealed record TaggingResponse
(
    Guid Id,
    string[] Tags
) : ResponseBase(Id);
