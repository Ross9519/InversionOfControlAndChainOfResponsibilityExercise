using DesignPatterns.ChainOfResponsibilityWithIoC.handlers;
using DesignPatterns.ChainOfResponsibilityWithIoC.host;
using Microsoft.Extensions.DependencyInjection;

var host = Container.CreateHost();

var handler = host.Services.GetRequiredService<IHandler>();

Console.WriteLine(handler.Greet("Pippo", "Poppi", "\"Michi, Carlo\""));