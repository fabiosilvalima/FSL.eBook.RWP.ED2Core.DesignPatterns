
using System.Collections.Generic;
using System.Linq;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.StrategyChapter
{
    public sealed class DescendingSortStrategy : 
        ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list = list.OrderByDescending(x => x).ToList();
        }
    }
}