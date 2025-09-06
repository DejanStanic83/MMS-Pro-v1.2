using Microsoft.Extensions.Configuration;
using MMS.Application.Services;

namespace MMS.Application.Services
{
    public class KlijentService
    {
        private readonly IConfiguration _config;
        private readonly IAppLogger _logger;

        public KlijentService(IConfiguration config, IAppLogger logger)
        {
            _config = config;
            _logger = logger;
        }

        public string GetBannerText()
        {
            return _config["Shell:BannerText"] ?? "MMS";
        }

        public void TestLog()
        {
            _logger.Info("Test info poruka iz KlijentService.");
            _logger.Warn("Test warning poruka iz KlijentService.");
            _logger.Error("Test error poruka iz KlijentService.");
        }
    }
}