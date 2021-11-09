using NLog;
using System.Text.Json;
using UserService.Contracts;

namespace UserService.Services
{
    public class LoggerService : ILoggerService
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogInfo(string message, object item)
        {
            string jsonString = JsonSerializer.Serialize(item);
            logger.Info(message + jsonString);
        }

        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}
