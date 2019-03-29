using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.StrategyChapter
{
    public sealed class StrategyController : 
        Controller
    {
        public IActionResult Index()
        {
            var list = new List<string>()
            {
                "fabio",
                "silva",
                "lima"
            };

            var sort = new Strategy(new DescendingSortStrategy());
            sort.Sort(list);
            sort = new Strategy(new AscendingSortStrategy());
            sort.Sort(list);
            sort = new Strategy(new BubleSortStrategy());
            sort.Sort(list);

            return Content("Strategy");
        }
    }
}