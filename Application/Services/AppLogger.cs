using System;
using Serilog;

namespace MMS.Application.Services
{
    public class AppLogger : IAppLogger
    {
        private readonly ILogger _logger;

        public AppLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Info(string message) => _logger.Information(message);
        public void Warn(string message) => _logger.Warning(message);
        public void Error(string message, Exception? ex = null) =>
            _logger.Error(ex, message);
    }
}