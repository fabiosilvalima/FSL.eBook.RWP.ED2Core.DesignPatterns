
namespace FSL.eBook.RWP.ED2Core.DesignPatterns.FactoryChapter
{
    public sealed class Truck : 
        ITransport
    {
        public string Build()
        {
            return "Truck transport";
        }
    }
}