using FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter;
using Microsoft.Extensions.Configuration;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public sealed class DapperSqlPaymentRepository : 
        DapperSqlRepository<Payment>, 
        IPaymentRepository
    {
        public DapperSqlPaymentRepository(
            IConfiguration configuration) :
            base(configuration)
        {
            TableName = "Payment";
        }
    }
}