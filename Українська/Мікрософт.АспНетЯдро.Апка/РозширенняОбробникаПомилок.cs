namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;

public static class РозширенняОбробникаПомилок
{
    public static IApplicationBuilder ВикористовуватиОбробникПомилок(this IApplicationBuilder апка) => ExceptionHandlerExtensions.UseExceptionHandler(апка);
    public static IApplicationBuilder ВикористовуватиОбробникПомилок(this IApplicationBuilder апка, string шляхОбробникаПомилок) => ExceptionHandlerExtensions.UseExceptionHandler(апка, шляхОбробникаПомилок);
    public static IApplicationBuilder ВикористовуватиОбробникПомилок(this IApplicationBuilder апка, string шляхОбробникаПомилок, bool створюватиОбластьДляПомилок) => ExceptionHandlerExtensions.UseExceptionHandler(апка, шляхОбробникаПомилок, створюватиОбластьДляПомилок);
    public static IApplicationBuilder ВикористовуватиОбробникПомилок(this IApplicationBuilder апка, Action<IApplicationBuilder> конфігурувати) => ExceptionHandlerExtensions.UseExceptionHandler(апка, конфігурувати);
    public static IApplicationBuilder ВикористовуватиОбробникПомилок(this IApplicationBuilder апка, ExceptionHandlerOptions опції) => ExceptionHandlerExtensions.UseExceptionHandler(апка, опції);
}
