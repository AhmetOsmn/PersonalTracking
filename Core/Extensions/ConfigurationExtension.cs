using Microsoft.Extensions.Configuration;

namespace Core.Extensions
{
    public static class ConfigurationExtension
    {
        private static IConfiguration _configuration;

        public static void SetConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static IConfiguration GetConfiguration() => _configuration;
        public static string? GetConnectionString() => GetConfiguration()?.GetSection("ConnectionString").Value;
        public static short GetSystemId() => Convert.ToInt16(GetConfiguration()?.GetSection("SystemInfo.SystemId").Value);
    }
}
