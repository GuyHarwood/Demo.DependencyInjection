namespace Common.Logging
{
    public class DebugWindowLogger : ILog
    {
        public void Log(string somethingToLog)
        {
            System.Diagnostics.Debug.WriteLine(somethingToLog);
        }
    }
}