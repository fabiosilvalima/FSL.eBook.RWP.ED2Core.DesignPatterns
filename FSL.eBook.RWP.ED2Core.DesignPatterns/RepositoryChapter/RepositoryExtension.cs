using Microsoft.Extensions.DependencyInjection;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter
{
    public static class RepositoryExtension
    {
        public static void UseRepository(
            this IServiceCollection services)
        {
            services.AddSingleton<IProductRepository, DapperSqlProductRepository>();
        }
    }
}