namespace Мікрософт.АспНетЯдро.Апка;
using Microsoft.AspNetCore.Builder;

public static class РозширенняБудівникаHsts
{
    public static IApplicationBuilder ВикористовуватиHsts(this IApplicationBuilder апка) => HstsBuilderExtensions.UseHsts(апка);
}
