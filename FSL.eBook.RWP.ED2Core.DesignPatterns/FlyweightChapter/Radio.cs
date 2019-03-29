namespace FSL.eBook.RWP.ED2Core.DesignPatterns.FlyweightChapter
{
    public sealed class Radio : 
        Control
    {
        public Radio()
        {
            Tag = Tags.Radio;
        }

        public override string Create(string text)
        {
            return $"<input type='radio' value='{text}' /> => {text}";
        }
    }
}