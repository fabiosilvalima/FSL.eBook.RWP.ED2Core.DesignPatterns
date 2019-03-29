using Microsoft.AspNetCore.Mvc;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.ProxyChapter
{
    public sealed class ProxyController : 
        Controller
    {
        public IActionResult Index(
            int id = 19)
        {
            var user = new User() { Age = id };
            var proxy = new CalcProxy(user);
            var result = proxy.Calculate();
            var message = proxy.Message;

            return Content($"result from Proxy: {result} of age {id}: {message}");
        }
    }
}