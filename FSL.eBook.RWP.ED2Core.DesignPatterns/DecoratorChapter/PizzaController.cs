using Microsoft.AspNetCore.Mvc;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.DecoratorChapter
{
    public sealed class PizzaController : 
        Controller
    {
        public IActionResult Index()
        {
            var pizza = new LargePizza();// large pizza
            var cheese = new CheeseDecorator(pizza); //large pizza with cheese
            var tomato = new TomatoDecorator(cheese); //large pizza with cheese and tomato

            return Content($"Decorator Pattern Pizza: {tomato.GetDescription()} - {tomato.CalculateCost()}");
        }
    }
}