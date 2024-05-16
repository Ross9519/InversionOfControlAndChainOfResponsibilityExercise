namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal class ShoutingHandler : Handler
    {
        public override string Greet(params string[] name)
        {
            if (name.Length > 0 && name.Single().All(char.IsUpper))
                return $"HELLO {name.Single()}!";
            else
                return base.Greet(name);
        }
    }
}
