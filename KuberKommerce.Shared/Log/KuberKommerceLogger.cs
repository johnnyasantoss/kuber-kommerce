using System;
using Microsoft.Extensions.Logging;

namespace KuberKommerce.Shared.Log
{
    internal class KuberKommerceLogger : ILogger
    {
        private readonly string _location;

        public KuberKommerceLogger(string location)
        {
            _location = location;
        }

        public void Log<TState>(
            LogLevel logLevel
            , EventId eventId
            , TState state
            , Exception exception
            , Func<TState, Exception, string> formatter
        )
        {
            var msg = $"[{_location}][{DateTime.Now:u}]{formatter(state, exception)}";
            Console.WriteLine(msg);
        }

        public bool IsEnabled(LogLevel logLevel)
            => true;

        public IDisposable BeginScope<TState>(TState state)
            => new FooDisposable();

        private class FooDisposable : IDisposable
        {
            public void Dispose()
            {
            }
        }
    }
}