namespace Imget.Shared.Messages.Rmq.Response;

public sealed record TaggingResponse
(
    Guid Id,
    string[] Tags
) : ResponseBase(Id);
