using Microsoft.Extensions.Hosting;

namespace Мікрософт.Розширення.Хостінг;

public interface ІХост: IHost
{
    IServiceProvider Сервіси { get; }

    Task ЗапуститиАсінх(CancellationToken cancellationToken = default);
    Task ЗупинитиАсінх(CancellationToken cancellationToken = default);
}
