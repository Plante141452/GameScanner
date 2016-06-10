using OpenQA.Selenium;

namespace GameScanner.Logic.Common.Interfaces
{
    public interface ITargetLocatorWrapper
    {
        IWebElementWrapper ActiveElement();
        IAlert Alert();
        IWebDriverWrapper DefaultContent();
        IWebDriverWrapper Frame(IWebElement frameElement);
        IWebDriverWrapper Frame(string frameName);
        IWebDriverWrapper Frame(int frameIndex);
        IWebDriverWrapper ParentFrame();
        IWebDriverWrapper Window(string windowName);
    }
}