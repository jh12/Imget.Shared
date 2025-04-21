namespace Imget.Shared.Configuration;

public sealed record RmqConfig
(
    string ConnectionString,
    string InputQueueName
);
