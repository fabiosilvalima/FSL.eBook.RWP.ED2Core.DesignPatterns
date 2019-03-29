using FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter;
using Microsoft.AspNetCore.Mvc;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.ServiceLocatorChapter
{
    public sealed class ProductController : 
        Controller
    {
        private IProductRepository ProductRepository
        {
            get
            {
                return DependencyResolver.Current.GetService<IProductRepository>();
            }
        }

        public IActionResult Index()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "product 1"
            };

            ProductRepository.Insert(product);

            return Content("Service Locator Pattern");
        }
    }
}