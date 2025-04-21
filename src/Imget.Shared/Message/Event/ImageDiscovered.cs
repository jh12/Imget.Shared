namespace Imget.Shared.Message.Event;

public record ImageDiscovered
(
    string Title,
    string Description,
    string[] Tags,
    string AttachmentId
);
