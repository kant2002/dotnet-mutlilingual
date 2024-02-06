namespace Мікрософт.Розширення.Хостінг;
using Microsoft.Extensions.Hosting;

public static class РозширенняОкруженияХоста
{
    public static bool ВРазработке(this IHostEnvironment окружениеХоста) => HostEnvironmentEnvExtensions.IsDevelopment(окружениеХоста);
    public static bool ВОкружении(this IHostEnvironment окружениеХоста, string названиеОкружения) => HostEnvironmentEnvExtensions.IsEnvironment(окружениеХоста, названиеОкружения);
    public static bool ВПроизводстве(this IHostEnvironment окружениеХоста) => HostEnvironmentEnvExtensions.IsProduction(окружениеХоста);
    //public static bool IsStaging(this IHostEnvironment окружениеХоста) => HostEnvironmentEnvExtensions.IsStaging(окружениеХоста);
}
