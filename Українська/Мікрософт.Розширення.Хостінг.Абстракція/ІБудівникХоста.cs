using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Мікрософт.Розширення.Хостінг;

public interface ІБудівникХоста
{
    /// <summary>
    /// A central location for sharing state between components during the host building process.
    /// </summary>
    IDictionary<object, object> Властивості { get; }

    /// <summary>
    /// Set up the configuration for the builder itself. This will be used to initialize the <see cref="IHostEnvironment"/>
    /// for use later in the build process. This can be called multiple times and the results will be additive.
    /// </summary>
    /// <param name="делегатКонфігурації">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
    /// to construct the <see cref="IConfiguration"/> for the host.</param>
    /// <returns>The same instance of the <see cref="IHostBuilder"/> for chaining.</returns>
    ІБудівникХоста СконфігуруватиКонфігураціюХоста(Action<IConfigurationBuilder> делегатКонфігурації);

    /// <summary>
    /// Sets up the configuration for the remainder of the build process and application. This can be called multiple times and
    /// the results will be additive. The results will be available at <see cref="HostBuilderContext.Configuration"/> for
    /// subsequent operations, as well as in <see cref="IHost.Services"/>.
    /// </summary>
    /// <param name="делегатКонфігурації">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
    /// to construct the <see cref="IConfiguration"/> for the application.</param>
    /// <returns>The same instance of the <see cref="IHostBuilder"/> for chaining.</returns>
    ІБудівникХоста СконфігуруватиКонфігураціюАпки(Action<HostBuilderContext, IConfigurationBuilder> делегатКонфігурації);

    /// <summary>
    /// Adds services to the container. This can be called multiple times and the results will be additive.
    /// </summary>
    /// <param name="делегатКонфігурації">The delegate for configuring the <see cref="IServiceCollection"/> that will be used
    /// to construct the <see cref="IServiceProvider"/>.</param>
    /// <returns>The same instance of the <see cref="IHostBuilder"/> for chaining.</returns>
    ІБудівникХоста СконфігуруватиСервіси(Action<HostBuilderContext, IServiceCollection> делегатКонфігурації);

    /// <summary>
    /// Overrides the factory used to create the service provider.
    /// </summary>
    /// <typeparam name="TContainerBuilder">The type of builder.</typeparam>
    /// <param name="factory">The factory to register.</param>
    /// <returns>The same instance of the <see cref="IHostBuilder"/> for chaining.</returns>
    ІБудівникХоста ВикористатиФабрикуПостачальникаСервісів<TContainerBuilder>(IServiceProviderFactory<TContainerBuilder> фабрика) where TContainerBuilder : notnull;

    /// <summary>
    /// Overrides the factory used to create the service provider.
    /// </summary>
    /// <typeparam name="TContainerBuilder">The type of builder.</typeparam>
    /// <param name="factory">The factory to register.</param>
    /// <returns>The same instance of the <see cref="IHostBuilder"/> for chaining.</returns>
    ІБудівникХоста ВикористатиФабрикуПостачальникаСервісів<TContainerBuilder>(Func<HostBuilderContext, IServiceProviderFactory<TContainerBuilder>> фабрика) where TContainerBuilder : notnull;

    /// <summary>
    /// Enables configuring the instantiated dependency container. This can be called multiple times and
    /// the results will be additive.
    /// </summary>
    /// <typeparam name="TContainerBuilder">The type of builder.</typeparam>
    /// <param name="configureDelegate">The delegate which configures the builder.</param>
    /// <returns>The same instance of the <see cref="IHostBuilder"/> for chaining.</returns>
    ІБудівникХоста СконфігуруватиКонтейнер<TContainerBuilder>(Action<HostBuilderContext, TContainerBuilder> делегатКонфігурації);

    /// <summary>
    /// Run the given actions to initialize the host. This can only be called once.
    /// </summary>
    /// <returns>An initialized <see cref="IHost"/>.</returns>
    ІХост Побудувати();
}
