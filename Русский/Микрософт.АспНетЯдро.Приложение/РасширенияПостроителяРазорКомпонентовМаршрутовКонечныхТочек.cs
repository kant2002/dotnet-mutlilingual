namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System.Diagnostics.CodeAnalysis;

public static class РасширенияПостроителяРазорКомпонентовМаршрутовКонечныхТочек
{
    public static RazorComponentsEndpointConventionBuilder ВідобразитиРазорКомпоненты<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TRootComponent>(this IEndpointRouteBuilder конечныеТочки) => RazorComponentsEndpointRouteBuilderExtensions.MapRazorComponents<TRootComponent>(конечныеТочки);
}
