using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Contracts
{
    public interface ILoggerService
    {
        void LogInfo(string message);
        void LogInfo(string message, object item);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}
