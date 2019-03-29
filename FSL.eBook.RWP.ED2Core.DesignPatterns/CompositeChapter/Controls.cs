using System.Collections.Generic;
using System.Text;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.CompositeChapter
{
    public sealed class Controls : 
        List<IControl>, 
        IControl
    {
        public int Id { get; set; }

        public string Render()
        {
            var sb = new StringBuilder();
            foreach(var control in this)
            {
                sb.Append($"{Id} : control: {control.Render()}</br>");
            }

            return sb.ToString();
        }
    }
}