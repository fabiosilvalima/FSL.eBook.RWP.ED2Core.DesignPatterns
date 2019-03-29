using FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter;
using Microsoft.Extensions.Configuration;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.ServiceLocatorChapter
{
    public static class ProductHelper
    {
        public static IProductRepository ProductRepository()
        {
            var repository = DependencyResolver.Current.GetService<IProductRepository>();
            var configuration = DependencyResolver.Current.GetService<IConfiguration>();

            if (repository == null)
            {
                repository = new DapperSqlProductRepository(
                    configuration);
            }

            return repository;
        }
    }
}