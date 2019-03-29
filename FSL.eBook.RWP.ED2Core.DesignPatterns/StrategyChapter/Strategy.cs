
using System.Collections.Generic;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.StrategyChapter
{
    public sealed class Strategy
    {
        private ISortStrategy _sortStrategy;

        public Strategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public List<string> Sort(List<string> list)
        {
            _sortStrategy.Sort(list);

            return list;
        }
    }
}