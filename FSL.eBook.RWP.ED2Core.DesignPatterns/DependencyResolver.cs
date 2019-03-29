using Microsoft.Extensions.DependencyInjection;
using System;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns
{
    // ******************************************************************************
    // Reference:
    // https://dotnetcoretutorials.com/2018/05/06/servicelocator-shim-for-net-core/
    // ******************************************************************************
    public sealed class DependencyResolver
    {
        private ServiceProvider _currentServiceProvider;
        private static ServiceProvider _serviceProvider;

        public DependencyResolver(
            ServiceProvider currentServiceProvider)
        {
            _currentServiceProvider = currentServiceProvider;
        }

        public static DependencyResolver Current
        {
            get
            {
                return new DependencyResolver(
                    _serviceProvider);
            }
        }

        public static void SetLocatorProvider(
            ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public object GetService(
            Type serviceType)
        {
            return _currentServiceProvider.GetService(
                serviceType);
        }

        public TService GetService<TService>()
        {
            return _currentServiceProvider.GetService<TService>();
        }
    }
}
