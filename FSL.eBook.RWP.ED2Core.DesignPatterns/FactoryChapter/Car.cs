
namespace FSL.eBook.RWP.ED2Core.DesignPatterns.FactoryChapter
{
    public sealed class Car : 
        ITransport
    {
        public string Build()
        {
            return "Car transport";
        }
    }
}