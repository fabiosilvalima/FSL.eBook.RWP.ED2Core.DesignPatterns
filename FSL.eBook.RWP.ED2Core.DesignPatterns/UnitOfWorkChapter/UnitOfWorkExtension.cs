using Microsoft.Extensions.DependencyInjection;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter
{
    public static class UnitOfWorkExtension
    {
        public static void UseUnitOfWork(
            this IServiceCollection services)
        {
            services.AddSingleton<Scenario1.IRegisterUnitOfWork, Scenario1.RegisterUnitOfWork>();
            services.AddSingleton<Scenario2.IProductRepository, Scenario2.DapperSqlProductRepository>();
            services.AddSingleton<Scenario2.IUnitOfWork, Scenario2.UnitOfWork>();
        }
    }
}