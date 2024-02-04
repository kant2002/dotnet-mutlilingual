namespace Мікрософт.Розширення.ВприскЗалежностей;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Endpoints;

public static class РозширенняКолекціїСервісівРазорКомпонентів
{
    public static IRazorComponentsBuilder ДодатиРазорКомпоненти(this IServiceCollection сервіси, Action<RazorComponentsServiceOptions>? конфігурувати = null) => RazorComponentsServiceCollectionExtensions.AddRazorComponents(сервіси, конфігурувати);
}
