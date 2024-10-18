using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace Мікрософт.Розширення.Хостінг;

/// <summary>
/// Provides information about the hosting environment an application is running in.
/// </summary>
public interface ІОточенняХоста : IHostEnvironment
{
    /// <summary>
    /// Gets or sets the name of the environment. The host automatically sets this property to the value of the
    /// "environment" key as specified in configuration.
    /// </summary>
    string НазваОточення { get; set; }

    /// <summary>
    /// Gets or sets the name of the application. This property is automatically set by the host to the assembly containing
    /// the application entry point.
    /// </summary>
    string НазваДодатка { get; set; }

    /// <summary>
    /// Gets or sets the absolute path to the directory that contains the application content files.
    /// </summary>
    string ШляхКореняКонтенту { get; set; }

    /// <summary>
    /// Gets or sets an <see cref="IFileProvider"/> pointing at <see cref="ШляхКореняКонтенту"/>.
    /// </summary>
    IFileProvider ПровайдерФайлівКореняКонтенту { get; set; }
}
