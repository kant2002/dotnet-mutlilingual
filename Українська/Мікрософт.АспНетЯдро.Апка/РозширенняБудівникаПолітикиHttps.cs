namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;

public static class РозширенняБудівникаПолітикиHttps
{
    public static IApplicationBuilder ВикористовуватиПеренаправленняHttps(this IApplicationBuilder апка) => HttpsPolicyBuilderExtensions.UseHttpsRedirection(апка);
}
