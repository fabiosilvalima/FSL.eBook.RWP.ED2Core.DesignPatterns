using System.Collections.Generic;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.FlyweightChapter
{
    public class ControlFactory
    {
        private readonly Dictionary<Tags, Control> Controls;

        public ControlFactory()
        {
            Controls = new Dictionary<Tags, Control>();
        }

        public Control GetControl(Tags tag)
        {
            if (!Controls.ContainsKey(tag))
            {
                switch (tag)
                {
                    case Tags.Text:
                        Controls.Add(tag, new Text());
                        break;
                    case Tags.Radio:
                        Controls.Add(tag, new Radio());
                        break;
                    case Tags.Button:
                        Controls.Add(tag, new Button());
                        break;
                }
            }

            return Controls[tag];
        }
    }
}