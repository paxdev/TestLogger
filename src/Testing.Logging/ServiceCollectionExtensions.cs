using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace PaxDev.Testing.Logging
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTestLogger(this IServiceCollection services) =>
            services
                .AddSingleton<ILoggerProvider, TestLoggerProvider>()
                .AddSingleton<TestLogger>();
    }
}