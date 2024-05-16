namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal class NullHandler : Handler
    {
        public override string Greet(params string[] name)
        {
            if (name.Length == 0)
                return $"Hello, my friend.";
            else
                return base.Greet(name.Single());
        }
    }
}
