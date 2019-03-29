using FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public sealed class RegisterUnitOfWork : 
        IRegisterUnitOfWork
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IProductRepository _productRepository;
        
        public RegisterUnitOfWork(IPaymentRepository paymentRepository, IProductRepository productRepository)
        {
            _paymentRepository = paymentRepository;
            _productRepository = productRepository;
        }

        public IPaymentRepository PaymentRepository
        {
            get
            {
                return _paymentRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                return _productRepository;
            }
        }

        public void Insert(Product product, Payment payment)
        {
            _productRepository.Insert(product);
            _paymentRepository.Insert(payment);
        }
    }
}