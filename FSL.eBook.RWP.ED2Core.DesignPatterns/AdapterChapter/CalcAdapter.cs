namespace FSL.eBook.RWP.ED2Core.DesignPatterns.AdapterChapter
{
    public sealed class CalcAdapter
    {
        public int CalculateArea(
            Square square)
        {
            var calcRectangle = new CalcRectangle();
            var rectangle = new Rectangle() { Width = square.Size, Height = square.Size };
            var area = calcRectangle.CalculateArea(rectangle);

            return area;
        }
    }
}