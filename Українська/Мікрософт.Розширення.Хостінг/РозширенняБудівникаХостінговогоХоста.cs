using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.Metrics;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Runtime.Versioning;

namespace Мікрософт.Розширення.Хостінг;

/// <summary>
/// Provides extension methods for the <see cref="ІБудівникХоста"/> from the hosting package.
/// </summary>
public static class РозширенняБудівникаХостінговогоХоста
{
    /// <summary>
    /// Specify the environment to be used by the host. To avoid the environment being overwritten by a default
    /// value, ensure this is called after defaults are configured.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста"/> to configure.</param>
    /// <param name="environment">The environment to host the application in.</param>
    /// <returns>The <see cref="ІБудівникХоста"/>.</returns>
    public static ІБудівникХоста ВикористовуватиОточення(this ІБудівникХоста hostBuilder, string environment)
        => (ІБудівникХоста)hostBuilder.UseEnvironment(environment);

    /// <summary>
    /// Specify the content root directory to be used by the host. To avoid the content root directory being
    /// overwritten by a default value, ensure this is called after defaults are configured.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста"/> to configure.</param>
    /// <param name="contentRoot">Path to root directory of the application.</param>
    /// <returns>The <see cref="ІБудівникХоста"/>.</returns>
    public static ІБудівникХоста ВикористовуватиКоріньКонтенту(this ІБудівникХоста hostBuilder, string contentRoot)
        => (ІБудівникХоста)hostBuilder.UseContentRoot(contentRoot);

    /// <summary>
    /// Specify the <see cref="IServiceProvider"/> to be the default one.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста"/> to configure.</param>
    /// <param name="configure">The delegate that configures the <see cref="IServiceProvider"/>.</param>
    /// <returns>The <see cref="ІБудівникХоста"/>.</returns>
    public static ІБудівникХоста ВикористовуватиУсталенийПостачальникСервісів(this ІБудівникХоста hostBuilder, Action<ServiceProviderOptions> configure)
        => (ІБудівникХоста)hostBuilder.UseDefaultServiceProvider(configure);

    /// <summary>
    /// Specify the <see cref="IServiceProvider"/> to be the default one.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста"/> to configure.</param>
    /// <param name="configure">The delegate that configures the <see cref="IServiceProvider"/>.</param>
    /// <returns>The <see cref="ІБудівникХоста"/>.</returns>
    public static ІБудівникХоста ВикористовуватиУсталенийПостачальникСервісів(this ІБудівникХоста hostBuilder, Action<КонтекстБудівникаХоста, ServiceProviderOptions> configure)
        => (ІБудівникХоста)hostBuilder.UseDefaultServiceProvider((context, provider) => configure(new КонтекстБудівникаХоста(context), provider));

    /// <summary>
    /// Adds a delegate for configuring the provided <see cref="ILoggingBuilder"/>. This may be called multiple times.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureLogging">The delegate that configures the <see cref="ILoggingBuilder"/>.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    public static ІБудівникХоста СконфігуруватиПротоколювання(this ІБудівникХоста hostBuilder, Action<КонтекстБудівникаХоста, ILoggingBuilder> configureLogging)
        => (ІБудівникХоста)hostBuilder.ConfigureLogging((context, builder) => configureLogging(new КонтекстБудівникаХоста(context), builder));

    /// <summary>
    /// Adds a delegate for configuring the provided <see cref="ILoggingBuilder"/>. This may be called multiple times.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureLogging">The delegate that configures the <see cref="ILoggingBuilder"/>.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    public static ІБудівникХоста СконфігуруватиПротоколювання(this ІБудівникХоста hostBuilder, Action<ILoggingBuilder> configureLogging)
        => (ІБудівникХоста)hostBuilder.ConfigureLogging(configureLogging);

    /// <summary>
    /// Adds a delegate for configuring the <see cref="HostOptions"/> of the <see cref="IHost"/>.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureOptions">The delegate for configuring the <see cref="HostOptions"/>.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    public static ІБудівникХоста СконфігуруватиНалаштуванняХоста(this ІБудівникХоста hostBuilder, Action<КонтекстБудівникаХоста, HostOptions> configureOptions)
        => (ІБудівникХоста)hostBuilder.ConfigureHostOptions((context, налаштування) => configureOptions(new КонтекстБудівникаХоста(context), налаштування));

    /// <summary>
    /// Adds a delegate for configuring the <see cref="HostOptions"/> of the <see cref="IHost"/>.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureOptions">The delegate for configuring the <see cref="HostOptions"/>.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    public static ІБудівникХоста СконфігуруватиНалаштуванняХоста(this ІБудівникХоста hostBuilder, Action<HostOptions> configureOptions)
        => (ІБудівникХоста)hostBuilder.ConfigureHostOptions(configureOptions);

    /// <summary>
    /// Sets up the configuration for the remainder of the build process and application. This can be called multiple times and
    /// the results will be additive. The results will be available at <see cref="КонтекстБудівникаХоста.Configuration"/> for
    /// subsequent operations, as well as in <see cref="IHost.Services"/>.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
    /// to construct the <see cref="IConfiguration"/> for the host.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    public static ІБудівникХоста СконфігуруватиКонфігураціюДодатка(this ІБудівникХоста hostBuilder, Action<IConfigurationBuilder> configureDelegate)
        => (ІБудівникХоста)hostBuilder.ConfigureAppConfiguration(configureDelegate);

    /// <summary>
    /// Adds services to the container. This can be called multiple times and the results will be additive.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IServiceCollection"/>.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    public static ІБудівникХоста СконфігуруватиСервіси(this ІБудівникХоста hostBuilder, Action<IServiceCollection> configureDelegate)
        => (ІБудівникХоста)hostBuilder.ConfigureServices(configureDelegate);

    /// <summary>
    /// Enables configuring the instantiated dependency container. This can be called multiple times and
    /// the results will be additive.
    /// </summary>
    /// <typeparam name="TContainerBuilder">The type of builder.</typeparam>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureDelegate">The delegate for configuring the <typeparamref name="TContainerBuilder"/>.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    public static ІБудівникХоста СконфігуруватиКонтейнер<TContainerBuilder>(this ІБудівникХоста hostBuilder, Action<TContainerBuilder> configureDelegate)
        => (ІБудівникХоста)hostBuilder.ConfigureContainer(configureDelegate);

    /// <summary>
    /// Configures an existing <see cref="ІБудівникХоста"/> instance with pre-configured defaults. This will overwrite
    /// previously configured values and is intended to be called before additional configuration calls.
    /// </summary>
    /// <remarks>
    ///   The following defaults are applied to the <see cref="ІБудівникХоста"/>:
    ///     * set the <see cref="IHostEnvironment.ContentRootPath"/> to the result of <see cref="Directory.GetCurrentDirectory()"/>
    ///     * load host <see cref="IConfiguration"/> from "DOTNET_" prefixed environment variables
    ///     * load host <see cref="IConfiguration"/> from supplied command line args
    ///     * load app <see cref="IConfiguration"/> from 'appsettings.json' and 'appsettings.[<see cref="IHostEnvironment.EnvironmentName"/>].json'
    ///     * load app <see cref="IConfiguration"/> from User Secrets when <see cref="IHostEnvironment.EnvironmentName"/> is 'Development' using the entry assembly
    ///     * load app <see cref="IConfiguration"/> from environment variables
    ///     * load app <see cref="IConfiguration"/> from supplied command line args
    ///     * configure the <see cref="ILoggerFactory"/> to log to the console, debug, and event source output
    ///     * enables scope validation on the dependency injection container when <see cref="IHostEnvironment.EnvironmentName"/> is 'Development'
    /// </remarks>
    /// <param name="builder">The existing builder to configure.</param>
    /// <param name="args">The command line args.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    public static ІБудівникХоста СконфігуруватиУсталення(this ІБудівникХоста builder, string[]? args)
        => (ІБудівникХоста)builder.ConfigureDefaults(args);

    /// <summary>
    /// Listens for Ctrl+C or SIGTERM and calls <see cref="IHostApplicationLifetime.StopApplication"/> to start the shutdown process.
    /// This will unblock extensions like RunAsync and WaitForShutdownAsync.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static ІБудівникХоста ВикористуватиКонсольнуТривалістьЖиття(this ІБудівникХоста hostBuilder)
        => (ІБудівникХоста)hostBuilder.UseConsoleLifetime();

    /// <summary>
    /// Listens for Ctrl+C or SIGTERM and calls <see cref="IHostApplicationLifetime.StopApplication"/> to start the shutdown process.
    /// This will unblock extensions like RunAsync and WaitForShutdownAsync.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureOptions">The delegate for configuring the <see cref="ConsoleLifetime"/>.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static ІБудівникХоста ВикористуватиКонсольнуТривалістьЖиття(this ІБудівникХоста hostBuilder, Action<ConsoleLifetimeOptions> configureOptions)
        => (ІБудівникХоста)hostBuilder.UseConsoleLifetime(configureOptions);

    /// <summary>
    /// Enables console support, builds and starts the host, and waits for Ctrl+C or SIGTERM to shut down.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken"/> that can be used to cancel the console.</param>
    /// <returns>A <see cref="Task"/> that only completes when the token is triggered or shutdown is triggered.</returns>
    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static Task ЗапуститиКонсольАсінх(this ІБудівникХоста hostBuilder, CancellationToken cancellationToken = default)
        => hostBuilder.RunConsoleAsync(cancellationToken);

    /// <summary>
    /// Enables console support, builds and starts the host, and waits for Ctrl+C or SIGTERM to shut down.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureOptions">The delegate for configuring the <see cref="ConsoleLifetime"/>.</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken"/> that can be used to cancel the console.</param>
    /// <returns>A <see cref="Task"/> that only completes when the token is triggered or shutdown is triggered.</returns>
    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static Task ЗапуститиКонсольАсінх(this ІБудівникХоста hostBuilder, Action<ConsoleLifetimeOptions> configureOptions, CancellationToken cancellationToken = default)
        => hostBuilder.RunConsoleAsync(configureOptions, cancellationToken);

    /// <summary>
    /// Adds a delegate for configuring the provided <see cref="IMetricsBuilder"/>. This may be called multiple times.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureMetrics">The delegate that configures the <see cref="IMetricsBuilder"/>.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    public static ІБудівникХоста СконфігуруватиМетріки(this ІБудівникХоста hostBuilder, Action<IMetricsBuilder> configureMetrics)
        => (ІБудівникХоста)hostBuilder.ConfigureMetrics(configureMetrics);

    /// <summary>
    /// Adds a delegate for configuring the provided <see cref="IMetricsBuilder"/>. This may be called multiple times.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ІБудівникХоста" /> to configure.</param>
    /// <param name="configureMetrics">The delegate that configures the <see cref="IMetricsBuilder"/>.</param>
    /// <returns>The same instance of the <see cref="ІБудівникХоста"/> for chaining.</returns>
    public static ІБудівникХоста СконфігуруватиМетріки(this ІБудівникХоста hostBuilder, Action<КонтекстБудівникаХоста, IMetricsBuilder> configureMetrics)
        => (ІБудівникХоста)hostBuilder.ConfigureMetrics((контекст, будівник) => configureMetrics(new КонтекстБудівникаХоста(контекст), будівник));
}
