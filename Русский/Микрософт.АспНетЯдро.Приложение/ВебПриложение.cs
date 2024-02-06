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

public sealed class ВебПриложение : IHost, IDisposable, IApplicationBuilder, IEndpointRouteBuilder, IAsyncDisposable
{
    private readonly WebApplication webApplication;

    internal ВебПриложение(WebApplication webApplication)
    {
        this.webApplication = webApplication;
    }

    public ICollection<string> Урлы => webApplication.Urls;
    public IHostApplicationLifetime ВремяЖизни => webApplication.Lifetime;
    public IWebHostEnvironment Окружение => webApplication.Environment;
    public IConfiguration Конфигурация => webApplication.Configuration;
    public IServiceProvider Сервисы => webApplication.Services;
    public ILogger Протоколировщик => webApplication.Logger;

    public static ВебПриложение Создать(string[]? арги = null) => new(WebApplication.Create(арги));
    public static ПостроительВебПриложения СоздатьПостроителя(WebApplicationOptions опции) => new(WebApplication.CreateBuilder(опции));
    public static ПостроительВебПриложения СоздатьПостроителя(string[] арги) => new(WebApplication.CreateBuilder(арги));
    public static ПостроительВебПриложения СоздатьПостроителя() => new(WebApplication.CreateBuilder());
    public static ПостроительВебПриложения СоздатьПустойПостроитель(WebApplicationOptions опции) => new(WebApplication.CreateEmptyBuilder(опции));
    public static ПостроительВебПриложения СоздатьСтройногоПостроителя(string[] арги) => new(WebApplication.CreateSlimBuilder(арги));
    public static ПостроительВебПриложения СоздатьСтройногоПостроителя() => new(WebApplication.CreateSlimBuilder());
    public static ПостроительВебПриложения СоздатьСтройногоПостроителя(WebApplicationOptions опции) => new(WebApplication.CreateSlimBuilder(опции));
    public ValueTask DisposeAsync() => this.webApplication.DisposeAsync();
    public void Запустить([StringSyntax("Uri")] string? урл = null) => webApplication.Run(урл);
    public Task ЗапуститьАсинх([StringSyntax("Uri")] string? урл = null) => webApplication.RunAsync(урл);
    public Task СтартоватьАсинх(CancellationToken маркерОтмены = default) => webApplication.StartAsync(маркерОтмены);
    public Task ОстановитьАсинх(CancellationToken маркерОтмены = default) => webApplication.StopAsync(маркерОтмены);
    public IApplicationBuilder Использовать(Func<RequestDelegate, RequestDelegate> прослойка) => webApplication.Use(прослойка);

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
