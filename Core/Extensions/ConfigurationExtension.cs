using Microsoft.Extensions.Configuration;

namespace Core.Extensions
{
    public static class ConfigurationExtension
    {
        private static IConfiguration _configuration = null;

        public static void SetConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static IConfiguration GetConfiguration() => _configuration;

        public static string? GetConnectionString() => GetConfiguration().GetSection("ConnectionString").Value;
    }
}
