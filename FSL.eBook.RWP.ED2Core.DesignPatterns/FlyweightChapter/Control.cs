namespace FSL.eBook.RWP.ED2Core.DesignPatterns.FlyweightChapter
{
    public enum Tags
    {
        Text = 1,
        Button = 2,
        Radio = 3
    }

    public abstract class Control 
    {
        public Tags Tag { get; set; }

        public abstract string Create(string text);
    }
}