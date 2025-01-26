namespace Imget.Shared.Messages.Rmq.Event;

public record ImageProcessed
(
    string Title,
    string Description,
    string[] Tags,
    Uri ThumbnailPath,
    Uri FullPath
);
