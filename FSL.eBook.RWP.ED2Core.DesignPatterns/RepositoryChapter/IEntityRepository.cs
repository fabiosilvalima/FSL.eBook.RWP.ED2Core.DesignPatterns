namespace FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter
{
    public interface IEntityRepository<TModel>
    {
        void Insert(
            TModel model);
    }
}
