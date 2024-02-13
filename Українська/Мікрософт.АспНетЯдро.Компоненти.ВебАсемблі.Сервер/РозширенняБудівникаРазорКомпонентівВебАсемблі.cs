namespace Мікрософт.Розширення.ВприскЗалежностей;
using Microsoft.Extensions.DependencyInjection;

public static class РозширенняБудівникаРазорКомпонентівВебАсемблі
{
    public static IRazorComponentsBuilder ДодатиІнтерактивніКомпонентиВебАсемблі(this IRazorComponentsBuilder будівник) => WebAssemblyRazorComponentsBuilderExtensions.AddInteractiveWebAssemblyComponents(будівник);
}
