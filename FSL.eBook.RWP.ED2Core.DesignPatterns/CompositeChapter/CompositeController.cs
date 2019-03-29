using Microsoft.AspNetCore.Mvc;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.CompositeChapter
{
    public sealed class CompositeController : 
        Controller
    {
        // GET: Composite
        public IActionResult Index()
        {
            var nodes = new Controls() { Id = 1 };
            nodes.Add(new Control() { Id = 2 });
            nodes.Add(new Control() { Id = 3 });
            IControl control = nodes;

            return Content($"Composite:</br> {control.Render()}");
        }
    }
}