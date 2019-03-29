namespace FSL.eBook.RWP.ED2Core.DesignPatterns.FlyweightChapter
{
    public sealed class Button : 
        Control
    {
        public Button()
        {
            Tag = Tags.Button;
        }

        public override string Create(string text)
        {
            return $"<input type='button' value='{text}' /> => {text}";
        }
    }
}