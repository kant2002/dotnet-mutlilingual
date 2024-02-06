namespace Мікрософт.Розширення.ВприскЗалежностей;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Server;

public static class РозширенняСерверногоПостроителяРазорКомпонентов
{
    public static IServerSideBlazorBuilder ДобавитьИнтерактивныеСерверныеКомпоненты(this IRazorComponentsBuilder построитель, Action<CircuitOptions>? конфигурировать = null) => ServerRazorComponentsBuilderExtensions.AddInteractiveServerComponents(построитель, конфигурировать);
}
