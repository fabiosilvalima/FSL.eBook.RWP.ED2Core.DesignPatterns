
namespace FSL.eBook.RWP.ED2Core.DesignPatterns.FactoryChapter
{
    public sealed class Bus : 
        ITransport
    {
        public string Build()
        {
            return "Bus transport";
        }
    }
}