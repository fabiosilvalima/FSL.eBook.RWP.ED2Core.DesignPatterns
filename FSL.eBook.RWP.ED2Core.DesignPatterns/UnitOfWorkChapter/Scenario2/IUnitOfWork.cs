namespace FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public interface IUnitOfWork
    {
        void Add(
            IEntity entity);

        void Commit();
    }
}
