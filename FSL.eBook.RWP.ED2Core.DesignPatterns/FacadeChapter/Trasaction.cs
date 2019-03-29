using System;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.FacadeChapter
{
    public sealed class Trasaction
    {
        private bool _transaction = false;

        public void Start()
        {
            _transaction = true;
        }

        public void Do(Action action)
        {
            action();
        }
        
        public void End()
        {
            _transaction = false;
        }
    }
}