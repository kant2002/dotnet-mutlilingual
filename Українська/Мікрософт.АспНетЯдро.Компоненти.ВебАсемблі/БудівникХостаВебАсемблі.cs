namespace Мікрософт.АспНетЯдро.Компоненти.ВебАсемблі.Хостінг;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

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

    [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(HeadOutlet))]
    public static БудівникХостаВебАсемблі СтворитиЗаЗамовчанням(string[]? арги = null) => new (WebAssemblyHostBuilder.CreateDefault(арги));

    public void НалаштуватиКонтейнер<ТБудівник>(IServiceProviderFactory<ТБудівник> фабрика, Action<ТБудівник>? конфігурувати = null)
        where ТБудівник: notnull
        => webAssemblyHostBuilder.ConfigureContainer(фабрика, конфігурувати);
    public ХостВебАсемблі Побудувати() => new (webAssemblyHostBuilder.Build());
}
