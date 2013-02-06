using System;

namespace Common.Logging
{
    public class ConsoleLogger : ILog
    {
        public void Log(string somethingToLog)
        {
            Console.WriteLine(somethingToLog);
        }
    }

    public class NoLogging : ILog
    {
        public void Log(string somethingToLog)
        {}
    }
}