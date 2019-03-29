using Microsoft.Extensions.Configuration;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter
{
    public sealed class SqlProductRepository : 
        SqlRepository, 
        IProductRepository
    {
        public SqlProductRepository(
            IConfiguration configuration) : 
            base(configuration)
        {

        }

        public void Insert(
            Product product)
        {

        }
    }
}