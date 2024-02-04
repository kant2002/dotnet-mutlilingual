namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;

public static class РозширенняБудівникаАплікаційАнтипідробки
{
    public static IApplicationBuilder ВикористовуватиАнтипідробку(this IApplicationBuilder будівник) => AntiforgeryApplicationBuilderExtensions.UseAntiforgery(будівник);
}
