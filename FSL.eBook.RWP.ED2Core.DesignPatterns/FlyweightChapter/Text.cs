namespace FSL.eBook.RWP.ED2Core.DesignPatterns.FlyweightChapter
{
    public sealed class Text : 
        Control
    {
        public Text()
        {
            Tag = Tags.Text;
        }

        public override string Create(string text)
        {
            return $"<input type='text' value='{text}' /> => {text}";
        }
    }
}