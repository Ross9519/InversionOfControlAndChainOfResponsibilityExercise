namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal class NthShoutingParams : Handler
    {
        public override string Greet(params string[] name)
        {
            if(name.Length > 2 && name.Any(n => n.All(char.IsUpper)))
            {
                var notUpperList = name.Where(n => !n.All(char.IsUpper));
                var upperList = name.Where(n => n.All(char.IsUpper));
                var notUCount = notUpperList.Count();
                var uCount = upperList.Count();

                return $"Hello, {string.Join(", ", 
                                    notUpperList
                                        .Select((n, index) => 
                                            notUCount > 1 && index == notUCount - 1 ? $"and {n}" : n))
                   }. AND HELLO {string.Join(", ", 
                                    upperList
                                        .Where(n => n.All(char.IsUpper))
                                        .Select((n, index) => 
                                            uCount > 1 && index == uCount - 1 ? $"and {n}" : n))}!";
            }
            return base.Greet(name);
        }
    }
}
