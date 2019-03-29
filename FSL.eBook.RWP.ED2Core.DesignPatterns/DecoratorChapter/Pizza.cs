namespace FSL.eBook.RWP.ED2Core.DesignPatterns.DecoratorChapter
{
    public abstract class Pizza
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double CalculateCost();
    }
}