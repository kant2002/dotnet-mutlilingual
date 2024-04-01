namespace Мікрософт.АспНетЯдро.Будівник;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Patterns;
using Microsoft.AspNetCore.Http;
using System.Diagnostics.CodeAnalysis;

public static class РозширенняБудівникаКінцевихТочокМаршруту
{
	public static IEndpointConventionBuilder Відобразити(this IEndpointRouteBuilder endpoints, RoutePattern pattern, RequestDelegate requestDelegate) => EndpointRouteBuilderExtensions.Map(endpoints, pattern, requestDelegate);

	[RequiresDynamicCode("This API may perform reflection on the supplied delegate and its parameters. These types may require generated code and aren't compatible with native AOT applications.")]
	[RequiresUnreferencedCode("This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced.")]
	public static RouteHandlerBuilder Відобразити(this IEndpointRouteBuilder endpoints, RoutePattern pattern, Delegate handler) => EndpointRouteBuilderExtensions.Map(endpoints, pattern, handler);

	[RequiresDynamicCode("This API may perform reflection on the supplied delegate and its parameters. These types may require generated code and aren't compatible with native AOT applications.")]
	[RequiresUnreferencedCode("This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced.")]
	public static RouteHandlerBuilder Відобразити(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, Delegate handler) => EndpointRouteBuilderExtensions.Map(endpoints, pattern, handler);

	public static IEndpointConventionBuilder Відобразити(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, RequestDelegate requestDelegate) => EndpointRouteBuilderExtensions.Map(endpoints, pattern, requestDelegate);

	[RequiresDynamicCode("This API may perform reflection on the supplied delegate and its parameters. These types may require generated code and aren't compatible with native AOT applications.")]
	[RequiresUnreferencedCode("This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced.")]
	public static RouteHandlerBuilder ВідобразитиDelete(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, Delegate handler) => EndpointRouteBuilderExtensions.MapDelete(endpoints, pattern, handler);

	public static IEndpointConventionBuilder ВідобразитиDelete(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, RequestDelegate requestDelegate) => EndpointRouteBuilderExtensions.MapDelete(endpoints, pattern, requestDelegate);

	//[RequiresDynamicCode("This API may perform reflection on the supplied delegate and its parameters. These types may require generated code and aren't compatible with native AOT applications.")]
	//[RequiresUnreferencedCode("This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced.")]
	//public static RouteHandlerBuilder MapFallback(this IEndpointRouteBuilder endpoints, Delegate handler) => EndpointRouteBuilderExtensions.MapFallback(endpoints, handler);

	//[RequiresDynamicCode("This API may perform reflection on the supplied delegate and its parameters. These types may require generated code and aren't compatible with native AOT applications.")]
	//[RequiresUnreferencedCode("This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced.")]
	//public static RouteHandlerBuilder MapFallback(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, Delegate handler) => EndpointRouteBuilderExtensions.MapDelete(endpoints, pattern, handler);

	[RequiresDynamicCode("This API may perform reflection on the supplied delegate and its parameters. These types may require generated code and aren't compatible with native AOT applications.")]
	[RequiresUnreferencedCode("This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced.")]
	public static RouteHandlerBuilder ВідобразитиGet(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, Delegate handler) => EndpointRouteBuilderExtensions.MapGet(endpoints, pattern, handler);

	public static IEndpointConventionBuilder ВідобразитиGet(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, RequestDelegate requestDelegate) => EndpointRouteBuilderExtensions.MapGet(endpoints, pattern, requestDelegate);

	public static RouteGroupBuilder ВідобразитиГрупу(this IEndpointRouteBuilder endpoints, RoutePattern prefix) => EndpointRouteBuilderExtensions.MapGroup(endpoints, prefix);

	public static RouteGroupBuilder ВідобразитиГрупу(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string prefix) => EndpointRouteBuilderExtensions.MapGroup(endpoints, prefix);

	[RequiresDynamicCode("This API may perform reflection on the supplied delegate and its parameters. These types may require generated code and aren't compatible with native AOT applications.")]
	[RequiresUnreferencedCode("This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced.")]
	public static RouteHandlerBuilder ВідобразитиМетоди(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, IEnumerable<string> httpMethods, Delegate handler) => EndpointRouteBuilderExtensions.MapMethods(endpoints, pattern, httpMethods, handler);

	public static IEndpointConventionBuilder ВідобразитиМетоди(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, IEnumerable<string> httpMethods, RequestDelegate requestDelegate) => EndpointRouteBuilderExtensions.MapMethods(endpoints, pattern, httpMethods, requestDelegate);

	public static IEndpointConventionBuilder ВідобразитиPatch(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, RequestDelegate requestDelegate) => EndpointRouteBuilderExtensions.MapPatch(endpoints, pattern, requestDelegate);

	[RequiresDynamicCode("This API may perform reflection on the supplied delegate and its parameters. These types may require generated code and aren't compatible with native AOT applications.")]
	[RequiresUnreferencedCode("This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced.")]
	public static RouteHandlerBuilder ВідобразитиPatch(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, Delegate handler) => EndpointRouteBuilderExtensions.MapPatch(endpoints, pattern, handler);

	[RequiresDynamicCode("This API may perform reflection on the supplied delegate and its parameters. These types may require generated code and aren't compatible with native AOT applications.")]
	[RequiresUnreferencedCode("This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced.")]
	public static RouteHandlerBuilder ВідобразитиPost(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, Delegate handler) => EndpointRouteBuilderExtensions.MapPost(endpoints, pattern, handler);

	public static IEndpointConventionBuilder ВідобразитиPost(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, RequestDelegate requestDelegate) => EndpointRouteBuilderExtensions.MapPost(endpoints, pattern, requestDelegate);

	public static IEndpointConventionBuilder ВідобразитиPut(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, RequestDelegate requestDelegate) => EndpointRouteBuilderExtensions.MapPut(endpoints, pattern, requestDelegate);

	[RequiresDynamicCode("This API may perform reflection on the supplied delegate and its parameters. These types may require generated code and aren't compatible with native AOT applications.")]
	[RequiresUnreferencedCode("This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced.")]
	public static RouteHandlerBuilder ВідобразитиPut(this IEndpointRouteBuilder endpoints, [StringSyntax("Route")] string pattern, Delegate handler) => EndpointRouteBuilderExtensions.MapPut(endpoints, pattern, handler);

}
