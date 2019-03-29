namespace FSL.eBook.RWP.ED2Core.DesignPatterns.DecoratorChapter
{
    public sealed class LargePizza : 
        Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }

        public override double CalculateCost()
        {
            return 45.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}