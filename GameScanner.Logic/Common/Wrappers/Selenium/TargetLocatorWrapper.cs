using GameScanner.Logic.Common.Interfaces;
using GameScanner.Logic.Helpers;
using OpenQA.Selenium;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class TargetLocatorWrapper : ITargetLocatorWrapper
    {
        private ITargetLocator _targetLocator;

        public TargetLocatorWrapper(ITargetLocator targetLocator)
        {
            _targetLocator = targetLocator;
        }

        public IWebElementWrapper ActiveElement()
        {
            return _targetLocator.ActiveElement().ToWrapper();
        }

        public IAlert Alert()
        {
            return _targetLocator.Alert().ToWrapper();
        }

        public IWebDriverWrapper DefaultContent()
        {
            return _targetLocator.DefaultContent().ToWrapper();
        }

        public IWebDriverWrapper Frame(IWebElement frameElement)
        {
            return _targetLocator.Frame(frameElement).ToWrapper();
        }

        public IWebDriverWrapper Frame(string frameName)
        {
            return _targetLocator.Frame(frameName).ToWrapper();
        }

        public IWebDriverWrapper Frame(int frameIndex)
        {
            return _targetLocator.Frame(frameIndex).ToWrapper();
        }

        public IWebDriverWrapper ParentFrame()
        {
            return _targetLocator.ParentFrame().ToWrapper();
        }

        public IWebDriverWrapper Window(string windowName)
        {
            return _targetLocator.Window(windowName).ToWrapper();
        }
    }
}
