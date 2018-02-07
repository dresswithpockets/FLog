namespace FLog.Logging.Formatters
{
    public interface ILoggerFormatter
    {
        string ApplyFormat(LogMessage logMessage);
    }
}
