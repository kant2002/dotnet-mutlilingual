namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System.Diagnostics.CodeAnalysis;

public static class РозширенняБудівникаРазорКомпонентівМаршрутівКінцевихТочок
{
    public static RazorComponentsEndpointConventionBuilder ВідобразитиРазорКомпоненти<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TRootComponent>(this IEndpointRouteBuilder кінцевіТочки) => RazorComponentsEndpointRouteBuilderExtensions.MapRazorComponents<TRootComponent>(кінцевіТочки);
}
