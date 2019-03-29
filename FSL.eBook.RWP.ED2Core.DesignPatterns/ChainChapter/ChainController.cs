using Microsoft.AspNetCore.Mvc;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.ChainChapter
{
    public sealed class ChainController : 
        Controller
    {
        public IActionResult Index()
        {
            var seller = new Seller("Fabio", 30);
            var localManager = new Seller("Fabiana", 50);
            var regionalManager = new Seller("Thomas", 70);

            seller.SetSuperior(localManager);
            localManager.SetSuperior(regionalManager);

            var result = seller.ApplyDiscount(40);
            if (result.Approved)
            {
                var message = $"Seller {result.SellerName} approved {result.Value}!";
            }

            return Content("Chain");
        }
    }
}