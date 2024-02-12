namespace Мікрософт.АспНетЯдро.Компоненти.ВебАсемблі.Хостінг;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

public sealed class БудівникХостаВебАсемблі
{
    private WebAssemblyHostBuilder webAssemblyHostBuilder;

    internal БудівникХостаВебАсемблі(WebAssemblyHostBuilder webAssemblyHostBuilder)
    {
        this.webAssemblyHostBuilder = webAssemblyHostBuilder;
    }

    public WebAssemblyHostConfiguration Конфігурація => webAssemblyHostBuilder.Configuration;

    public RootComponentMappingCollection КорневіКомпоненти => webAssemblyHostBuilder.RootComponents;

    public IServiceCollection Сервіси => webAssemblyHostBuilder.Services;

    public IWebAssemblyHostEnvironment ОточенняХоста => webAssemblyHostBuilder.HostEnvironment;

    public ILoggingBuilder Протоколювання => webAssemblyHostBuilder.Logging;

    public static БудівникХостаВебАсемблі CreateDefault(string[]? args = null) => new (WebAssemblyHostBuilder.CreateDefault(args));

    public void ConfigureContainer<TBuilder>(IServiceProviderFactory<TBuilder> factory, Action<TBuilder>? configure = null)
        where TBuilder: notnull
        => webAssemblyHostBuilder.ConfigureContainer(factory, configure);
    public ХостВебАсемблі Build() => new (webAssemblyHostBuilder.Build());
}
