using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace PaxDev.Testing.Logging
{
    public class TestLoggerProvider : ILoggerProvider
    {
        readonly IServiceProvider serviceProvider;

        public TestLoggerProvider(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public void Dispose()
        {
        }

        public ILogger CreateLogger(string categoryName)
        {
            return serviceProvider.GetService<TestLogger>();
        }
    }
}