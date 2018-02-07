namespace FLog.Logging
{
    public interface ILoggerHandler
    {
        void Publish(LogMessage logMessage);
    }
}