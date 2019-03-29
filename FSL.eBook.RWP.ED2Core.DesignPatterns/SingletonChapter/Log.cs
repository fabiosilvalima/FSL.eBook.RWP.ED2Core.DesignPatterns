using System;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.SingletonChapter
{
    public sealed class Log
    {
        private static volatile ILog instance;
        private static object syncRoot = new Object();

        private Log() { }

        public static ILog Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = DependencyResolver.Current.GetService<ILog>();
                        }
                    }
                }

                return instance;
            }
        }
    }
}