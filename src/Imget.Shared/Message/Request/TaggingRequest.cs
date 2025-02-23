namespace Imget.Shared.Message.Request;

public sealed record TaggingRequest
(
    Guid Id,
    string? Title,
    string? Description,
    string[]? Tags
) : RequestBase(Id);
