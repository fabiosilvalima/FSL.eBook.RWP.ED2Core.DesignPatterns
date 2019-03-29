using Microsoft.AspNetCore.Mvc;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.AdapterChapter
{
    public sealed class AdapterController : 
        Controller
    {
        public IActionResult Index()
        {
            var square = new Square() { Size = 50 };
            var calc = new CalcAdapter();
            var area = calc.CalculateArea(square);

            return Content($"ADAPTER PATTERN AREA of square {square.Size}: {area}");
        }
    }
}