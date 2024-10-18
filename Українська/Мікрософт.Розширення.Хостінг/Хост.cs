using Microsoft.Extensions.Hosting;

namespace Мікрософт.Розширення.Хостінг;

public static class Хост
{
    public static ІБудівникХоста СтворитиУсталенийБудівник() =>
        СтворитиУсталенийБудівник(арги: null);

    public static ІБудівникХоста СтворитиУсталенийБудівник(string[]? арги)
    {
        БудівникХоста builder = new();
        return builder.СконфігуруватиУсталення(арги);
    }
    public static HostApplicationBuilder СтворитиБудівникДодатка() => Host.CreateApplicationBuilder();
    public static HostApplicationBuilder СтворитиБудівникДодатка(string[]? args) => Host.CreateApplicationBuilder(args);

    /// <inheritdoc cref="СтворитиБудівникДодатка()" />
    /// <param name="settings">Controls the initial configuration and other settings for constructing the <see cref="HostApplicationBuilder"/>.</param>
    public static HostApplicationBuilder СтворитиБудівникДодатка(НалаштуванняБудівникаДодаткаХоста? settings)
        => Host.CreateApplicationBuilder(settings == null ? null : new HostApplicationBuilderSettings() { Configuration = settings.Конфігурація, EnvironmentName = settings.НазваОточення, ApplicationName = settings.НазваДодатку, Args = settings.Арги, ContentRootPath = settings.ШляхКореняКонтенту, DisableDefaults = settings.ВідключитиУсталення });

    /// <summary>
    /// Initializes a new instance of the <see cref="HostApplicationBuilder"/> class with no pre-configured defaults.
    /// </summary>
    /// <param name="settings">Controls the initial configuration and other settings for constructing the <see cref="HostApplicationBuilder"/>.</param>
    /// <returns>The initialized <see cref="HostApplicationBuilder"/>.</returns>
    public static HostApplicationBuilder СтворитиПорожнійБудівникДодатка(НалаштуванняБудівникаДодаткаХоста? settings) => Host.CreateEmptyApplicationBuilder(settings == null ? null : new HostApplicationBuilderSettings() { Configuration = settings.Конфігурація, EnvironmentName = settings.НазваОточення, ApplicationName = settings.НазваДодатку, Args = settings.Арги, ContentRootPath = settings.ШляхКореняКонтенту, DisableDefaults = settings.ВідключитиУсталення });
}
