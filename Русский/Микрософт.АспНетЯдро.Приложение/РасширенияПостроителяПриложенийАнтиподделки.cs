namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;

public static class РасширенияПостроителяПриложенийАнтиподделки
{
    public static IApplicationBuilder ИспользоватьАнтиподделку(this IApplicationBuilder построитель) => AntiforgeryApplicationBuilderExtensions.UseAntiforgery(построитель);
}
