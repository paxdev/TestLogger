using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace PaxDev.Testing.Logging
{
    public class TestLogger<T> : TestLogger, ILogger<T>
    {
    }

    public class TestLogger : ILogger
    {
        public List<TestLogEntry> Logs { get; set; } = new List<TestLogEntry>();

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter) =>
            Logs.Add(new TestLogEntry
            {
                LogLevel = logLevel,
                Message = formatter(state, exception),
                Exception = exception
            });

        public bool IsEnabled(LogLevel logLevel) => true;

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }
    }
}
