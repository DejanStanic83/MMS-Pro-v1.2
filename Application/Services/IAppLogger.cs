using System;

namespace MMS.Application.Services
{
    public interface IAppLogger
    {
        void Info(string message);
        void Warn(string message);
        void Error(string message, Exception? ex = null);
    }
}