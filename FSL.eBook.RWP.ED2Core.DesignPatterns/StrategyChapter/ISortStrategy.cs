
using System.Collections.Generic;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.StrategyChapter
{
    public interface ISortStrategy
    {
        void Sort(
            List<string> list);
    }
}