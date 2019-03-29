using System;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.SingletonChapter
{
    public interface ILog
    {
        void LogException(
            Exception ex);
    }
}