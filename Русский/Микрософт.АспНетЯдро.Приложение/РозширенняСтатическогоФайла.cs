namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;

public static class РозширенняСтатическогоФайла
{
    public static IApplicationBuilder ИспользоватьСтатическиеФайлы(this IApplicationBuilder приложение) => StaticFileExtensions.UseStaticFiles(приложение);
    public static IApplicationBuilder ИспользоватьСтатическиеФайлы(this IApplicationBuilder приложение, string путьЗапроса) => StaticFileExtensions.UseStaticFiles(приложение, путьЗапроса);
    public static IApplicationBuilder ИспользоватьСтатическиеФайлы(this IApplicationBuilder приложение, StaticFileOptions опции) => StaticFileExtensions.UseStaticFiles(приложение, опции);
}
