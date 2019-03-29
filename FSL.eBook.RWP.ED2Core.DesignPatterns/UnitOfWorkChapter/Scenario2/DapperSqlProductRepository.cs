
using Microsoft.Extensions.Configuration;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public sealed class DapperSqlProductRepository : 
        RepositoryChapter.DapperSqlRepository<Product>, 
        IProductRepository
    {
        public DapperSqlProductRepository(
            IConfiguration configuration) :
            base(configuration)
        {
            TableName = "Product";

        }
    }
}