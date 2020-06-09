using System;
using Microsoft.Extensions.Logging;

namespace PaxDev.Testing.Logging
{
    public class TestLogEntry
    {
        public LogLevel LogLevel { get; set; }
        public Exception Exception { get; set; }
        public string Message { get; set; }
    }
}