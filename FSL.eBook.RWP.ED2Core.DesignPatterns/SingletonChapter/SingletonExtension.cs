using Microsoft.Extensions.DependencyInjection;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.SingletonChapter
{
    public static class SingletonExtension
    {
        public static void UseSingleton(
            this IServiceCollection services)
        {
            services.AddSingleton<ILog, DatabaseLog>();
        }
    }
}