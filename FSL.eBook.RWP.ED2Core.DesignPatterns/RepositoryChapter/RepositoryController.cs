using Microsoft.AspNetCore.Mvc;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter
{
    public sealed class RepositoryController : 
        Controller
    {
        private readonly IProductRepository _productRepository;

        public RepositoryController(
            IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public IActionResult Index()
        {
            var product = new Product()
            {
                Id = 200,
                Name = "Product 200"
            };

            _productRepository.Insert(product);

            return Content("Repository Pattern");
        }
    }
}