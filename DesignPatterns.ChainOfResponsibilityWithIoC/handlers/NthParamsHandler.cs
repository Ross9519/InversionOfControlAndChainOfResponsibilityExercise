namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal class NthParamsHandler : Handler
    {
        public override string Greet(params string[] name)
        {
            if (name.Length > 2)
                return $"Hello, {string.Join(", ", 
                                    name.Select((n, index) =>
                                        index == name.Length - 1 ? $"and {n}" : n))}";
            else
                return base.Greet(name);
        }
    }
}
