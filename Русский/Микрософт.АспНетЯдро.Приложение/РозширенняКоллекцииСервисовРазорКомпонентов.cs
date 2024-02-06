namespace Мікрософт.Розширення.ВприскЗалежностей;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Endpoints;

public static class РозширенняКоллекцииСервисовРазорКомпонентов
{
    public static IRazorComponentsBuilder ДобавитьРазорКомпоненты(this IServiceCollection сервисы, Action<RazorComponentsServiceOptions>? конфигурировать = null) => RazorComponentsServiceCollectionExtensions.AddRazorComponents(сервисы, конфигурировать);
}
