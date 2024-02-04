namespace Мікрософт.Розширення.Хостінг;
using Microsoft.Extensions.Hosting;

public static class РозширенняОточенняХоста
{
    public static bool УРозробці(this IHostEnvironment оточенняХоста) => HostEnvironmentEnvExtensions.IsDevelopment(оточенняХоста);
    public static bool УОточенні(this IHostEnvironment оточенняХоста, string назваОточення) => HostEnvironmentEnvExtensions.IsEnvironment(оточенняХоста, назваОточення);
    public static bool УВиробництві(this IHostEnvironment оточенняХоста) => HostEnvironmentEnvExtensions.IsProduction(оточенняХоста);
    //public static bool IsStaging(this IHostEnvironment оточенняХоста) => HostEnvironmentEnvExtensions.IsStaging(оточенняХоста);
}
