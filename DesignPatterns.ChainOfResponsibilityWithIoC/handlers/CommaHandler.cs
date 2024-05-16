namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal class CommaHandler : Handler
    {
        public override string Greet(params string[] name)
        {
            if (name.Length > 2 && !name.Any(n => n.All(char.IsUpper)))
            {
                var listSplitted = name
                        .Where(n => !n.Contains(','))
                        .Concat(name.Where(n => n.Contains(','))
                        .SelectMany(n => n.Split(",")))
                        .ToList();

                return $"Hello, {string.Join(", ", 
                                    listSplitted
                                        .Select((n, index) =>
                                            index == listSplitted.Count - 1 ? $"and {n}" : n))}";
            }
            else
            return base.Greet(name);
        }
    }
}
