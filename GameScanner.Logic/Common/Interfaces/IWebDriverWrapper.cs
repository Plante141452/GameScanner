using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace GameScanner.Logic.Common.Interfaces
{
    public interface IWebDriverWrapper
    {
        string CurrentWindowHandle { get; }
        string PageSource { get; }
        string Title { get; }
        string Url { get; set; }
        ReadOnlyCollection<string> WindowHandles { get; }

        void Close();
        void Dispose();
        IWebElementWrapper FindElement(By by, double seconds = 10d);
        ReadOnlyCollection<IWebElementWrapper> FindElements(By by, double seconds = 10d);
        IOptions Manage();
        INavigation Navigate();
        void Quit();
        ITargetLocatorWrapper SwitchTo();
    }
}