namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;

public static class РозширенняБудівникаHttpПротоколювання
{
	public static IApplicationBuilder ВикористовуватиHttpПротоколювання(this IApplicationBuilder апка) => HttpLoggingBuilderExtensions.UseHttpLogging(апка);
	public static IApplicationBuilder ВикористовуватиW3CПротоколювання(this IApplicationBuilder апка) => HttpLoggingBuilderExtensions.UseHttpLogging(апка);

}
