using FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.LazyLoadingChapter
{
    public sealed class ProductService
    {
        private IProductRepository _productRepository;
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                       _productRepository = DependencyResolver.Current.GetService<IProductRepository>();
                }

                return _productRepository;
            }
        }
    }
}