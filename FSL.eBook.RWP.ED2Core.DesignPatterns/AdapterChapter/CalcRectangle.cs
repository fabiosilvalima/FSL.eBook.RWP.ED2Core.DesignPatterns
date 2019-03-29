namespace FSL.eBook.RWP.ED2Core.DesignPatterns.AdapterChapter
{
    public sealed class CalcRectangle
    {
        public int CalculateArea(
            Rectangle rectangle)
        {
            int area = (rectangle.Width * rectangle.Height);

            return area;
        }
    }
}