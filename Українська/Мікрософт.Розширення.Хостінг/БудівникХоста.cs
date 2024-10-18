using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Мікрософт.Розширення.Хостінг;

public class БудівникХоста : HostBuilder, ІБудівникХоста
{
    /// <summary>
    /// Initializes a new instance of <see cref="HostBuilder"/>.
    /// </summary>
    public БудівникХоста() : base()
    {
    }

    public IDictionary<object, object> Властивості => base.Properties;

    public ІБудівникХоста ВикористатиФабрикуПостачальникаСервісів<TContainerBuilder>(IServiceProviderFactory<TContainerBuilder> фабрика) where TContainerBuilder : notnull
        => (ІБудівникХоста)base.UseServiceProviderFactory(фабрика);

    public ІБудівникХоста ВикористатиФабрикуПостачальникаСервісів<TContainerBuilder>(Func<HostBuilderContext, IServiceProviderFactory<TContainerBuilder>> фабрика) where TContainerBuilder : notnull
        => (ІБудівникХоста)base.UseServiceProviderFactory(фабрика);

    public ІХост Побудувати() => new ВнутрішнійХост(base.Build());

    public ІБудівникХоста СконфігуруватиКонтейнер<TContainerBuilder>(Action<HostBuilderContext, TContainerBuilder> делегатКонфігурації)
        => (ІБудівникХоста)base.ConfigureContainer(делегатКонфігурації);

    public ІБудівникХоста СконфігуруватиКонфігураціюАпки(Action<HostBuilderContext, IConfigurationBuilder> делегатКонфігурації)
        => (ІБудівникХоста)base.ConfigureAppConfiguration(делегатКонфігурації);

    public ІБудівникХоста СконфігуруватиКонфігураціюХоста(Action<IConfigurationBuilder> делегатКонфігурації)
        => (ІБудівникХоста)base.ConfigureHostConfiguration(делегатКонфігурації);

    public ІБудівникХоста СконфігуруватиСервіси(Action<HostBuilderContext, IServiceCollection> делегатКонфігурації)
        => (ІБудівникХоста)base.ConfigureServices(делегатКонфігурації);
}
