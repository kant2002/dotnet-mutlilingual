namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;

public static class РасширенияПостроителяПолитикиHttps
{
    public static IApplicationBuilder ИспользоватьПеренаправлениеHttps(this IApplicationBuilder приложение) => HttpsPolicyBuilderExtensions.UseHttpsRedirection(приложение);
}
