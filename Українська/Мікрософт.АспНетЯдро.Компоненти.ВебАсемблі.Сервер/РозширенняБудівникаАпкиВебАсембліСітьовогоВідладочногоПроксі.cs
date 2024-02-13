namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;

public static class РозширенняБудівникаАпкиВебАсембліСітьовогоВідладочногоПроксі
{
    public static void ВикористовуватиВідладчикВебАсемблі(this IApplicationBuilder апка) => WebAssemblyNetDebugProxyAppBuilderExtensions.UseWebAssemblyDebugging(апка);
}
