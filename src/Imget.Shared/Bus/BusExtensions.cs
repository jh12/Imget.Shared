using Imget.Shared.Message.Event;
using Rebus.Bus;

namespace Imget.Shared.Bus;

public static class BusExtensions
{
    public static async Task<IBus> SubscribeInboundImageEvents(this IBus bus)
    {
        await bus.Subscribe<ImageFound>();
        await bus.Subscribe<ImageFileAcquired>();
        await bus.Subscribe<ImageMetadataAcquired>();
        await bus.Subscribe<ImageOrganized>();
        await bus.Subscribe<ImageTagsAcquired>();
        await bus.Subscribe<ImageThumbnailAcquired>();

        return bus;
    }

    public static async Task<IBus> SubscribeOutboundImageEvents(this IBus bus)
    {
        await bus.Subscribe<AcquireImageFile>();
        await bus.Subscribe<AcquireImageMetadata>();
        await bus.Subscribe<AcquireImageTags>();
        await bus.Subscribe<AcquireImageThumbnail>();
        await bus.Subscribe<OrganizeImage>();
        await bus.Subscribe<ImageProcessed>();

        return bus;
    }

    public static async Task<IBus> SubscribeAllImageEvents(this IBus bus)
    {
        await bus.SubscribeInboundImageEvents();
        await bus.SubscribeOutboundImageEvents();

        return bus;
    }
}
