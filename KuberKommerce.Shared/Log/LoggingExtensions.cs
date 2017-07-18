using Microsoft.Extensions.Logging;

namespace KuberKommerce.Shared.Log
{
    public static class LoggingExtensions
    {
        public static void AddKuberKommerceLog(this ILoggerFactory loggerFactory, string location)
            => loggerFactory.AddProvider(new KuberKommerceLoggerProvider(location));
    }
}