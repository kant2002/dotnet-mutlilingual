namespace Мікрософт.АспНетЯдро.Апка;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.Metrics;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public sealed class БудівникВебАплікації : IHostApplicationBuilder
{
    private readonly WebApplicationBuilder webApplicationBuilder;

    internal БудівникВебАплікації(WebApplicationBuilder webApplicationBuilder)
    {
        this.webApplicationBuilder = webApplicationBuilder;
    }

    public IWebHostEnvironment Оточення => webApplicationBuilder.Environment;
    public IServiceCollection Сервіси => webApplicationBuilder.Services;
    public ConfigurationManager Конфігурація => webApplicationBuilder.Configuration;
    public ILoggingBuilder Протоколювач => webApplicationBuilder.Logging;
    public IMetricsBuilder Метріки => webApplicationBuilder.Metrics;
    public ConfigureWebHostBuilder ВебХост => webApplicationBuilder.WebHost;
    public ConfigureHostBuilder Хост => webApplicationBuilder.Host;

    public ВебАплікація Побудувати() => new(webApplicationBuilder.Build());

    IConfigurationManager IHostApplicationBuilder.Configuration => ((IHostApplicationBuilder)webApplicationBuilder).Configuration;

    IHostEnvironment IHostApplicationBuilder.Environment => ((IHostApplicationBuilder)webApplicationBuilder).Environment;

    ILoggingBuilder IHostApplicationBuilder.Logging => ((IHostApplicationBuilder)webApplicationBuilder).Logging;

    IMetricsBuilder IHostApplicationBuilder.Metrics => ((IHostApplicationBuilder)webApplicationBuilder).Metrics;

    IDictionary<object, object> IHostApplicationBuilder.Properties => ((IHostApplicationBuilder)webApplicationBuilder).Properties;

    IServiceCollection IHostApplicationBuilder.Services => ((IHostApplicationBuilder)webApplicationBuilder).Services;

    void IHostApplicationBuilder.ConfigureContainer<TContainerBuilder>(IServiceProviderFactory<TContainerBuilder> factory, Action<TContainerBuilder>? configure) => ((IHostApplicationBuilder)webApplicationBuilder).ConfigureContainer(factory, configure);
}
