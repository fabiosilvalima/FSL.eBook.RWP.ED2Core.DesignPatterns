
using System.Collections.Generic;
using System.Linq;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.StrategyChapter
{
    public sealed class AscendingSortStrategy : 
        ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list = list.OrderBy(x => x).ToList();
        }
    }
}