namespace FSL.eBook.RWP.ED2Core.DesignPatterns.CompositeChapter
{
    public class Control : 
        IControl
    {
        public int Id { get; set; }

        public string Render()
        {
            return $"control {Id}";
        }
    }
}