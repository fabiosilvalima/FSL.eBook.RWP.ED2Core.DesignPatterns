using Microsoft.AspNetCore.Mvc;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public sealed class UnitOfWorkController : 
        Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "product 1"
            };

            var payment = new Payment()
            {
                Id = 1,
                Name = "product 1",
                ProductId = product.Id
            };

            _unitOfWork.Add(product);
            _unitOfWork.Add(payment);
            _unitOfWork.Commit();
            
            return Content("Unit Of Work Pattern");
        }
    }
}