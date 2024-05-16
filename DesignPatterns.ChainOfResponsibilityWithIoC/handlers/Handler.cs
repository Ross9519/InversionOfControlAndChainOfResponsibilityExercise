namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal class Handler : IHandler
    {
        private IHandler _next;
        public IHandler SetNext(IHandler next)
        {
            _next = next;
            return _next;
        }

        public virtual string Greet(params string[] name)
            => _next.Greet(name);

    }
}
