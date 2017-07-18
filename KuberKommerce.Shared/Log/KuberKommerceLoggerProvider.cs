using Microsoft.Extensions.Logging;

namespace KuberKommerce.Shared.Log
{
    public class KuberKommerceLoggerProvider : ILoggerProvider
    {
        private readonly string _location;

        public KuberKommerceLoggerProvider(string location)
        {
            _location = location;
        }
        
        public void Dispose()
        {
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new KuberKommerceLogger(_location);
        }
    }
}