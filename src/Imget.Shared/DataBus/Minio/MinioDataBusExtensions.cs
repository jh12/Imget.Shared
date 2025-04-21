using Imget.Shared.Configuration;
using Rebus.Config;
using Rebus.DataBus;

namespace Imget.Shared.DataBus.Minio;

public static class MinioDataBusExtensions
{
    public static void UseMinioBlobStorage(this StandardConfigurer<IDataBusStorage> configurer, MinioDataBusConfig config)
    {
        if (configurer == null)
        {
            throw new ArgumentNullException(nameof(configurer));
        }

        if (config == null)
        {
            throw new ArgumentNullException(nameof(config));
        }

        configurer.OtherService<MinioDataBusStorage>().Register(c => new MinioDataBusStorage(config));
        configurer.Register(c => c.Get<MinioDataBusStorage>());
        configurer.OtherService<IDataBusStorageManagement>().Register(c => c.Get<MinioDataBusStorage>());
    }
}
