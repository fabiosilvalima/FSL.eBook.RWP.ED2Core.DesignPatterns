namespace FSL.eBook.RWP.ED2Core.DesignPatterns.ProxyChapter
{
    public interface ICalc
    {
        double Calculate();
        string Message { get; set; }
    }
}