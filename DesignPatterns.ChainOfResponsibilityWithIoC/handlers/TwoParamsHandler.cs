namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal class TwoParamsHandler : Handler
    {
        public override string Greet(params string[] name)
        {
            if (name.Length == 2)
                return $"Hello, {name[0]} and {name[1]}.";
            else
                return base.Greet(name);
        }
    }
}
