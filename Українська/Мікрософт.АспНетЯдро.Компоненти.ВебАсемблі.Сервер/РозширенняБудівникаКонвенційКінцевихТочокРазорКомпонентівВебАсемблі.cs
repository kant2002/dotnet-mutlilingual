﻿namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.WebAssembly.Server;

public static class РозширенняБудівникаКонвенційКінцевихТочокРазорКомпонентівВебАсемблі
{
    public static RazorComponentsEndpointConventionBuilder ДодатиІнтерактивнийРежимРендеруВебАсемблі(this RazorComponentsEndpointConventionBuilder будівник, Action<WebAssemblyComponentsEndpointOptions>? зворотнийВиклик = null) => WebAssemblyRazorComponentsEndpointConventionBuilderExtensions.AddInteractiveWebAssemblyRenderMode(будівник, зворотнийВиклик);
}
