namespace Мікрософт.АспНетЯдро.Апка;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public sealed class ВебАплікація : IHost, IDisposable, IApplicationBuilder, IEndpointRouteBuilder, IAsyncDisposable
{
    private readonly WebApplication webApplication;

    internal ВебАплікація(WebApplication webApplication)
    {
        this.webApplication = webApplication;
    }

    public ICollection<string> Урли => webApplication.Urls;
    public IHostApplicationLifetime ЧасЖиття => webApplication.Lifetime;
    public IWebHostEnvironment Оточення => webApplication.Environment;
    public IConfiguration Конфігурація => webApplication.Configuration;
    public IServiceProvider Сервіси => webApplication.Services;
    public ILogger Протоколювач => webApplication.Logger;

    public static ВебАплікація Створити(string[]? args = null) => new(WebApplication.Create(args));
    public static БудівникВебАплікації СтворитиБудівника(WebApplicationOptions options) => new(WebApplication.CreateBuilder(options));
    public static БудівникВебАплікації СтворитиБудівника(string[] args) => new(WebApplication.CreateBuilder(args));
    public static БудівникВебАплікації СтворитиБудівника() => new(WebApplication.CreateBuilder());
    public static БудівникВебАплікації СтворитиПустогоБудівника(WebApplicationOptions options) => new(WebApplication.CreateEmptyBuilder(options));
    public static БудівникВебАплікації СтворитиСтрункогоБудівника(string[] args) => new(WebApplication.CreateSlimBuilder(args));
    public static БудівникВебАплікації СтворитиСтрункогоБудівника() => new(WebApplication.CreateSlimBuilder());
    public static БудівникВебАплікації СтворитиСтрункогоБудівника(WebApplicationOptions options) => new(WebApplication.CreateSlimBuilder(options));
    public ValueTask DisposeAsync() => this.webApplication.DisposeAsync();
    public void Запустити([StringSyntax("Uri")] string? урл = null) => webApplication.Run(урл);
    public Task ЗапуститиАсінх([StringSyntax("Uri")] string? урл = null) => webApplication.RunAsync(урл);
    public Task СтартуватиАсінх(CancellationToken маркерВідміни = default) => webApplication.StartAsync(маркерВідміни);
    public Task ЗупинитиАсінх(CancellationToken маркерВідміни = default) => webApplication.StopAsync(маркерВідміни);
    public IApplicationBuilder Використовувати(Func<RequestDelegate, RequestDelegate> проміжник) => webApplication.Use(проміжник);

    IServiceProvider IEndpointRouteBuilder.ServiceProvider => ((IEndpointRouteBuilder)webApplication).ServiceProvider;

    ICollection<EndpointDataSource> IEndpointRouteBuilder.DataSources => ((IEndpointRouteBuilder)webApplication).DataSources;

    IServiceProvider IApplicationBuilder.ApplicationServices { get => ((IApplicationBuilder)webApplication).ApplicationServices; set => throw new NotImplementedException(); }

    IFeatureCollection IApplicationBuilder.ServerFeatures => ((IApplicationBuilder)webApplication).ServerFeatures;

    IDictionary<string, object?> IApplicationBuilder.Properties => ((IApplicationBuilder)webApplication).Properties;

    IServiceProvider IHost.Services => ((IHost)webApplication).Services;

    IApplicationBuilder IEndpointRouteBuilder.CreateApplicationBuilder() => ((IEndpointRouteBuilder)webApplication).CreateApplicationBuilder();

    void IDisposable.Dispose()
    {
        ((IDisposable)webApplication).Dispose();
    }

    IApplicationBuilder IApplicationBuilder.Use(Func<RequestDelegate, RequestDelegate> middleware) => ((IApplicationBuilder)webApplication).Use(middleware);

    IApplicationBuilder IApplicationBuilder.New() => ((IApplicationBuilder)webApplication).New();

    RequestDelegate IApplicationBuilder.Build() => ((IApplicationBuilder)webApplication).Build();

    Task IHost.StartAsync(CancellationToken cancellationToken) => ((IHost)webApplication).StartAsync(cancellationToken);

    Task IHost.StopAsync(CancellationToken cancellationToken) => ((IHost)webApplication).StopAsync(cancellationToken);
}
