using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.FactoryChapter
{
    public sealed class FactoryController : 
        Controller
    {
        public IActionResult Manually()
        {
            var car = new Car();
            var truck = new Truck();
            var bus = new Bus();

            var transports = new List<ITransport>();
            transports.Add(car);
            transports.Add(truck);
            transports.Add(bus);

            foreach (var transport in transports)
            {
                var result = transport.Build();
            }

            return Content("Factory Manually");
        }

        public IActionResult Dinamically()
        {
            var types = new List<string>() { "Car", "Truck", "Bus" };
            var transports = new List<ITransport>();
            types.ForEach(x => transports.Add(TransportFactory.CreateInstance(x)));
            
            foreach (var transport in transports)
            {
                var result = transport.Build();
            }

            return Content("Factory Dinamically");
        }
    }
}