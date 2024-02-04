namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;

public static class РозширенняСтатичногоФайла
{
    public static IApplicationBuilder ВикористовуватиСтатичніФайли(this IApplicationBuilder апка) => StaticFileExtensions.UseStaticFiles(апка);
    public static IApplicationBuilder ВикористовуватиСтатичніФайли(this IApplicationBuilder апка, string шлязЗапиту) => StaticFileExtensions.UseStaticFiles(апка, шлязЗапиту);
    public static IApplicationBuilder ВикористовуватиСтатичніФайли(this IApplicationBuilder апка, StaticFileOptions опції) => StaticFileExtensions.UseStaticFiles(апка, опції);
}
