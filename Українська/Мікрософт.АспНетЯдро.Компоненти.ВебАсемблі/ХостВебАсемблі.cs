namespace Мікрософт.АспНетЯдро.Компоненти.ВебАсемблі;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;

public sealed class ХостВебАсемблі : IAsyncDisposable
{
    private readonly WebAssemblyHost webAssemblyHost;

    internal ХостВебАсемблі(WebAssemblyHost webAssemblyHost)
    {
        this.webAssemblyHost = webAssemblyHost;
    }

    public IConfiguration Конфігурація => this.webAssemblyHost.Configuration;

    public IServiceProvider Сервіси => this.webAssemblyHost.Services;

    public ValueTask DisposeAsync() => this.webAssemblyHost.DisposeAsync();

    public Task ЗапуститиАсінх() => this.webAssemblyHost.RunAsync();
}
