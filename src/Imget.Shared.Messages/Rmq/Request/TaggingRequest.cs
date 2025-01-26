namespace Imget.Shared.Messages.Rmq.Request;

public sealed record TaggingRequest
(
    Guid Id,
    string? Title,
    string? Description,
    string[]? Tags
) : RequestBase(Id);
