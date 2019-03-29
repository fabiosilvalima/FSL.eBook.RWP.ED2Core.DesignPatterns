namespace FSL.eBook.RWP.ED2Core.DesignPatterns.ProxyChapter
{
    public sealed class Calc : 
        ICalc
    {
        public string Message { get; set; }

        public double Calculate()
        {
            Message = "Calculated!";

            return 32 * 9;
        }
    }
}