namespace Мікрософт.АспНетЯдро.Апка;
using Microsoft.AspNetCore.Builder;

public static class РасширенияПостроителяHsts
{
    public static IApplicationBuilder ИспользоватьHsts(this IApplicationBuilder приложение) => HstsBuilderExtensions.UseHsts(приложение);
}
