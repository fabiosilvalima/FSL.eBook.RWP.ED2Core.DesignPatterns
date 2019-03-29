using Microsoft.Extensions.DependencyInjection;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public static class UnitOfWorkExtension
    {
        public static void UseUnitOfWorkScenario1(
            this IServiceCollection services)
        {
            services.AddSingleton<IRegisterUnitOfWork, RegisterUnitOfWork>();
        }
    }
}