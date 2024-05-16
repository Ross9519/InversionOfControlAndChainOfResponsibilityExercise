namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler next);
        string Greet(params string[] name);
    }
}
