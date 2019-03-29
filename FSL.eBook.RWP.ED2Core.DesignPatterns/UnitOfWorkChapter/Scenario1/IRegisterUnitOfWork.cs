using FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public interface IRegisterUnitOfWork
    {
        void Insert(Product product, Payment payment);
        IProductRepository ProductRepository { get; }
        IPaymentRepository PaymentRepository { get; }
    }
}
