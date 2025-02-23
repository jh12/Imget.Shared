namespace Imget.Shared.Message.Event;

public record ImageProcessed
(
    string Title,
    string Description,
    string[] Tags,
    Uri ThumbnailPath,
    Uri FullPath
);
