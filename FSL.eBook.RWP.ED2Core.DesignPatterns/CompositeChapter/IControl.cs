namespace FSL.eBook.RWP.ED2Core.DesignPatterns.CompositeChapter
{
    public interface IControl
    {
        int Id { get; set; }
        string Render();
    }
}