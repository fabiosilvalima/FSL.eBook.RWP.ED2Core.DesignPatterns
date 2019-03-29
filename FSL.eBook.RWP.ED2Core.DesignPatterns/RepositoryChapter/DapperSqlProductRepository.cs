
using Microsoft.Extensions.Configuration;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter
{
    public sealed class DapperSqlProductRepository : 
        DapperSqlRepository<Product>, 
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