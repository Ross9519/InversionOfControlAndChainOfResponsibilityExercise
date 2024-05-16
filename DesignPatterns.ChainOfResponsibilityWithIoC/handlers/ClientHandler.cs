namespace DesignPatterns.ChainOfResponsibilityWithIoC.handlers
{
    internal static class ClientHandler
    {
        public static IHandler GetHandler()
        {
            var intentionalComma = new IntentionalCommaHandler();
            var comma = new CommaHandler();
            var nthShoutingParams = new NthShoutingParams();
            var nthParams = new NthParamsHandler();
            var twoParams = new TwoParamsHandler();
            var shouting = new ShoutingHandler();
            var nullName = new NullHandler();
            var baseName = new BaseHandler();

            intentionalComma
                .SetNext(comma)
                .SetNext(nthShoutingParams)
                .SetNext(nthParams)
                .SetNext(twoParams)
                .SetNext(shouting)
                .SetNext(nullName)
                .SetNext(baseName);

            return intentionalComma;
        }
    }
}
