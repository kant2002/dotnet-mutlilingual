using Microsoft.Extensions.Hosting;

namespace Мікрософт.Розширення.Хостінг;

internal class ВнутрішнійХост : ІХост
{
    private readonly IHost host;

    public ВнутрішнійХост(IHost host) => this.host = host;

    public IServiceProvider Сервіси => this.host.Services;

    public IServiceProvider Services => this.host.Services;

    public void Dispose() => this.host.Dispose();

    public Task StartAsync(CancellationToken cancellationToken = default) => this.host.StartAsync(cancellationToken);

    public Task StopAsync(CancellationToken cancellationToken = default) => this.host.StopAsync(cancellationToken);

    public Task ЗапуститиАсінх(CancellationToken cancellationToken = default) => this.host.StartAsync(cancellationToken);

    public Task ЗупинитиАсінх(CancellationToken cancellationToken = default) => this.host.StopAsync(cancellationToken);
}
