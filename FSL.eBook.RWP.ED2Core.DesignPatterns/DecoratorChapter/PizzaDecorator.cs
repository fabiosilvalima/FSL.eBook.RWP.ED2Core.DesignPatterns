namespace FSL.eBook.RWP.ED2Core.DesignPatterns.DecoratorChapter
{
    public abstract class PizzaDecorator : 
        Pizza
    {
        private Pizza _pizza;

        public PizzaDecorator(
            Pizza pizza)
        {
            _pizza = pizza;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }
    }
}