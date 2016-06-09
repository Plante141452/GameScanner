using GameScanner.Logic.Helpers;
using OpenQA.Selenium;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class TargetLocatorWrapper : ITargetLocator
    {
        private ITargetLocator _targetLocator;

        public TargetLocatorWrapper(ITargetLocator targetLocator)
        {
            _targetLocator = targetLocator;
        }

        public IWebElement ActiveElement()
        {
            return _targetLocator.ActiveElement().ToWrapper();
        }

        public IAlert Alert()
        {
            return _targetLocator.Alert().ToWrapper();
        }

        public IWebDriver DefaultContent()
        {
            return _targetLocator.DefaultContent().ToWrapper();
        }

        public IWebDriver Frame(IWebElement frameElement)
        {
            return _targetLocator.Frame(frameElement).ToWrapper();
        }

        public IWebDriver Frame(string frameName)
        {
            return _targetLocator.Frame(frameName).ToWrapper();
        }

        public IWebDriver Frame(int frameIndex)
        {
            return _targetLocator.Frame(frameIndex).ToWrapper();
        }

        public IWebDriver ParentFrame()
        {
            return _targetLocator.ParentFrame().ToWrapper();
        }

        public IWebDriver Window(string windowName)
        {
            return _targetLocator.Window(windowName).ToWrapper();
        }
    }
}
