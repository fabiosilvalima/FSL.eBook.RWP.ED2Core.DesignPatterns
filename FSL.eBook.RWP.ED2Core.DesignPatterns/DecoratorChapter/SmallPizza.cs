namespace FSL.eBook.RWP.ED2Core.DesignPatterns.DecoratorChapter
{
    public sealed class SmallPizza : 
        Pizza
    {
        public SmallPizza()
        {
            Description = "Small Pizza";
        }

        public override double CalculateCost()
        {
            return 20.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}