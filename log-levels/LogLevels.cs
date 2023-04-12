using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.IndexOf(": ")+1).Trim();
        
    }

    public static string LogLevel(string logLine)
    {
         return logLine.Substring(logLine.IndexOf("[")+1,logLine.IndexOf("]")-1).Trim().ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string message = logLine.Substring(logLine.IndexOf(": ")+1).Trim();
        string error = logLine.Substring(logLine.IndexOf("[")+1,logLine.IndexOf("]")-1).Trim().ToLower();
        return $"{message} ({error})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
