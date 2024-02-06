namespace Мікрософт.АспНетЯдро.Апка;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.Metrics;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public sealed class ПостроительВебПриложения : IHostApplicationBuilder
{
    private readonly WebApplicationBuilder webApplicationBuilder;

    internal ПостроительВебПриложения(WebApplicationBuilder webApplicationBuilder)
    {
        this.webApplicationBuilder = webApplicationBuilder;
    }

    public IWebHostEnvironment Окружение => webApplicationBuilder.Environment;
    public IServiceCollection Сервиси => webApplicationBuilder.Services;
    public ConfigurationManager Конфигурация => webApplicationBuilder.Configuration;
    public ILoggingBuilder Протоколировщик => webApplicationBuilder.Logging;
    public IMetricsBuilder Метрики => webApplicationBuilder.Metrics;
    public ConfigureWebHostBuilder ВебХост => webApplicationBuilder.WebHost;
    public ConfigureHostBuilder Хост => webApplicationBuilder.Host;

    public ВебПриложение Построить() => new(webApplicationBuilder.Build());

    IConfigurationManager IHostApplicationBuilder.Configuration => ((IHostApplicationBuilder)webApplicationBuilder).Configuration;

    IHostEnvironment IHostApplicationBuilder.Environment => ((IHostApplicationBuilder)webApplicationBuilder).Environment;

    ILoggingBuilder IHostApplicationBuilder.Logging => ((IHostApplicationBuilder)webApplicationBuilder).Logging;

    IMetricsBuilder IHostApplicationBuilder.Metrics => ((IHostApplicationBuilder)webApplicationBuilder).Metrics;

    IDictionary<object, object> IHostApplicationBuilder.Properties => ((IHostApplicationBuilder)webApplicationBuilder).Properties;

    IServiceCollection IHostApplicationBuilder.Services => ((IHostApplicationBuilder)webApplicationBuilder).Services;

    void IHostApplicationBuilder.ConfigureContainer<TContainerBuilder>(IServiceProviderFactory<TContainerBuilder> factory, Action<TContainerBuilder>? configure) => ((IHostApplicationBuilder)webApplicationBuilder).ConfigureContainer(factory, configure);
}
