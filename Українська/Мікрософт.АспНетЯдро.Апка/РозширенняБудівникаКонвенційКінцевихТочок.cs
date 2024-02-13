namespace Мікрософт.АспНетЯдро.Будівник;
using Microsoft.AspNetCore.Builder;
using System.Reflection;

public static class РозширенняБудівникаКонвенційКінцевихТочок
{
    public static RazorComponentsEndpointConventionBuilder ДодатиДодатковіЗбірки(this RazorComponentsEndpointConventionBuilder будівник, params Assembly[] збірки) => RazorComponentsEndpointConventionBuilderExtensions.AddAdditionalAssemblies(будівник, збірки);
}
