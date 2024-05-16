namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal class BaseHandler : Handler
    {
        public override string Greet(params string[] name)
            => $"Hello, {name.Single()}.";
    }
}
