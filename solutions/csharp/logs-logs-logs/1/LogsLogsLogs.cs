// TODO: define the 'LogLevel' enum
public enum LogLevel
    {
        Unknown=0,
        Trace=1, 
        Debug=2,
        Info=4,
        Warning=5,
        Error=6,
        Fatal=42
    }
static class LogLine
{
    
    public static LogLevel ParseLogLevel(string logLine)
    {
        int position = logLine.IndexOf(":");
        var key = logLine.Substring(0, position);
        switch(key)
        {
            case "[TRC]":
                return LogLevel.Trace;
                break;
            case "[DBG]":
                return LogLevel.Debug;
                break;
            case "[INF]":
                return LogLevel.Info;
                break;
            case "[WRN]":
                return LogLevel.Warning;
                break;
            case "[ERR]":
                return LogLevel.Error;
                break;
            case "[FTL]":
                return LogLevel.Fatal;
                break;
            default:
                return LogLevel.Unknown;
                break;
        }
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        int shortLog = (int)logLevel;
         return $"{shortLog}:{message}"; 
    }
}