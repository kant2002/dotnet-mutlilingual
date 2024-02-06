namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;

public static class РозширенняОбработчикаПомилок
{
    public static IApplicationBuilder ИспользоватьОбработчикОшибок(this IApplicationBuilder приложение) => ExceptionHandlerExtensions.UseExceptionHandler(приложение);
    public static IApplicationBuilder ИспользоватьОбработчикОшибок(this IApplicationBuilder приложение, string путьОбработчикаОшибок) => ExceptionHandlerExtensions.UseExceptionHandler(приложение, путьОбработчикаОшибок);
    public static IApplicationBuilder ИспользоватьОбработчикОшибок(this IApplicationBuilder приложение, string путьОбработчикаОшибок, bool создаватьОбластьДляОшибок) => ExceptionHandlerExtensions.UseExceptionHandler(приложение, путьОбработчикаОшибок, создаватьОбластьДляОшибок);
    public static IApplicationBuilder ИспользоватьОбработчикОшибок(this IApplicationBuilder приложение, Action<IApplicationBuilder> конфигурировать) => ExceptionHandlerExtensions.UseExceptionHandler(приложение, конфигурировать);
    public static IApplicationBuilder ИспользоватьОбработчикОшибок(this IApplicationBuilder приложение, ExceptionHandlerOptions опции) => ExceptionHandlerExtensions.UseExceptionHandler(приложение, опции);
}
