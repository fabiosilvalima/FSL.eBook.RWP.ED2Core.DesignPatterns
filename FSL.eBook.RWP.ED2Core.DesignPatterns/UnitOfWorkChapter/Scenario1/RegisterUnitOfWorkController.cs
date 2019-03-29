using FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter;
using Microsoft.AspNetCore.Mvc;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public sealed class RegisterUnitOfWorkController : 
        Controller
    {
        private readonly IRegisterUnitOfWork _unitOfWork;

        public RegisterUnitOfWorkController(IRegisterUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Together()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "product 1"
            };

            var payment = new Payment()
            {
                Id = 1,
                Name = "payment 1",
                ProductId = product.Id
            };

            _unitOfWork.Insert(product, payment);

            return Content("Unit Of Work Pattern");
        }

        public IActionResult Separated()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "product 1"
            };

            _unitOfWork.ProductRepository.Insert(product);

            return Content("Unit Of Work Pattern");
        }
    }
}