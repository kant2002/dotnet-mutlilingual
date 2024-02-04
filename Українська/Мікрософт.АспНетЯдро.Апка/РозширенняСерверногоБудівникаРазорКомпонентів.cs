namespace Мікрософт.Розширення.ВприскЗалежностей;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Server;

public static class РозширенняСерверногоБудівникаРазорКомпонентів
{
    public static IServerSideBlazorBuilder ДодатиІнтерактивніСерверніКомпоненти(this IRazorComponentsBuilder будівник, Action<CircuitOptions>? конфігурувати = null) => ServerRazorComponentsBuilderExtensions.AddInteractiveServerComponents(будівник, конфігурувати);
}
