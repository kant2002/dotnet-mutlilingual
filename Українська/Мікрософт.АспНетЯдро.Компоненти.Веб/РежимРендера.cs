namespace Мікрософт.АспНетЯдро.Компоненти.Веб;
using Microsoft.AspNetCore.Components.Web;


public static class РежимРендера
{
    public static InteractiveServerRenderMode ІнтерактивнийСервер => RenderMode.InteractiveServer;
    public static InteractiveWebAssemblyRenderMode ІнтерактивнийВебАсемблі => RenderMode.InteractiveWebAssembly;
    public static InteractiveAutoRenderMode ІнтерактивнийАвто => RenderMode.InteractiveAuto;
}
