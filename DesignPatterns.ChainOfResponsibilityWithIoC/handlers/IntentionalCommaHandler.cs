using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal class IntentionalCommaHandler : Handler
    {
        public override string Greet(params string[] name)
        {
            if (name.Length > 2 && !name.Any(n => n.All(char.IsUpper)) && name.Any(n => n.Contains('\"')))
                return $"Hello, {string.Join(", ", 
                                    name.Select(n => n.Replace("\"", ""))
                                        .Select((n, index) => 
                                            index == name.Length - 1 ? $"and {n}" : n))}.";
            else
                return base.Greet(name);
        }
    }
}
