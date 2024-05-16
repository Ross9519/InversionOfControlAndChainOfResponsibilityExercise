using DesignPatterns.ChainOfResponsibilityWithIoC.handlers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DesignPatterns.ChainOfResponsibilityWithIoC.host
{
    internal static class Container
    {
        public static IHost CreateHost()
            => Host
                .CreateDefaultBuilder()
                .ConfigureServices((_, service) =>
                {
                    service.AddSingleton(_ => ClientHandler.GetHandler());
                })
                .Build();
    }
}
