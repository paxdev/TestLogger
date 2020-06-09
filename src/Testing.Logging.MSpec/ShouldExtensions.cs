using System;
using Machine.Specifications;
using Microsoft.Extensions.Logging;

namespace PaxDev.Testing.Logging.MSpec
{
    public static class ShouldExtensions
    {

        public static void ShouldHaveLogEntry(this TestLogger testLogger, Exception exception, LogLevel logLevel, string message) =>
            testLogger
                .Logs
                .ShouldContain(e => e.Exception == exception
                                              && e.LogLevel == logLevel
                                              && e.Message == message);
    }
}
