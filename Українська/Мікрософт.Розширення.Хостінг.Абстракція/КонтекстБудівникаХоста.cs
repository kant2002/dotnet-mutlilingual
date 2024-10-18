using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Мікрософт.Розширення.Хостінг;

/// <summary>
/// Context containing the common services on the <see cref="IHost" />. Some properties may be null until set by the <see cref="IHost" />.
/// </summary>
public class КонтекстБудівникаХоста : HostBuilderContext
{
    /// <summary>
    /// Initializes a new instance of <see cref="HostBuilderContext"/>.
    /// </summary>
    /// <param name="properties">A non-null <see cref="IDictionary{TKey, TValue}"/> for sharing state between components during the host building process.</param>
    public КонтекстБудівникаХоста(IDictionary<object, object> properties) : base(properties)
    {
    }

    public КонтекстБудівникаХоста(HostBuilderContext hostBuilderContext) : base(hostBuilderContext.Properties) { }

    /// <summary>
    /// The <see cref="ІОточенняХоста" /> initialized by the <see cref="IHost" />.
    /// </summary>
    public ІОточенняХоста ОточенняХоста
    {
        get => (ІОточенняХоста)base.HostingEnvironment;
        set => base.HostingEnvironment = value;
    }

    /// <summary>
    /// The <see cref="IConfiguration" /> containing the merged configuration of the application and the <see cref="IHost" />.
    /// </summary>
    public IConfiguration Конфігурація
    {
        get => base.Configuration;
        set => base.Configuration = value;
    }

    /// <summary>
    /// A central location for sharing state between components during the host building process.
    /// </summary>
    public IDictionary<object, object> Властивості => base.Properties;
}
