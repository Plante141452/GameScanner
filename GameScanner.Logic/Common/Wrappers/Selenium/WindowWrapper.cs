using OpenQA.Selenium;
using System.Drawing;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class WindowWrapper : IWindow
    {
        private IWindow _window;

        public WindowWrapper(IWindow window)
        {
            _window = window;
        }

        public Point Position
        {
            get { return _window.Position; }
            set { _window.Position = value; }
        }

        public Size Size
        {
            get { return _window.Size; }
            set { _window.Size = value; }
        }

        public void Maximize()
        {
            _window.Maximize();
        }
    }
}
