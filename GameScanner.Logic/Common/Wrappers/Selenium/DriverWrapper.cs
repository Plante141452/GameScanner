using OpenQA.Selenium;
using System.Linq;
using System.Collections.ObjectModel;
using GameScanner.Logic.Helpers;
using GameScanner.Logic.Common.Managers;
using GameScanner.Logic.Common.Interfaces;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class DriverWrapper : IWebDriverWrapper
    {
        private IWebDriver _driver;

        public DriverWrapper(IWebDriver driver)
        {
            _driver = driver;
        }

        public string CurrentWindowHandle
        {
            get { return _driver.CurrentWindowHandle; }
        }

        public string PageSource
        {
            get { return _driver.PageSource; }
        }

        public string Title
        {
            get { return _driver.Title; }
        }

        public string Url
        {
            get { return _driver.Url; }

            set { _driver.Url = value; }
        }

        public ReadOnlyCollection<string> WindowHandles
        {
            get { return _driver.WindowHandles; }
        }

        public void Close()
        {
            _driver.Close();
            _driver.Dispose();
            DriverManager.CloseDriver();
        }

        public void Dispose()
        {
            _driver.Close();
            _driver.Dispose();
            DriverManager.CloseDriver();
        }
        
        public IWebElementWrapper FindElement(By by, double seconds = 10d)
        {
            return SeleniumHelper.Wait(() => _driver.FindElement(by), seconds).ToWrapper();
        }
        
        public ReadOnlyCollection<IWebElementWrapper> FindElements(By by, double seconds = 10d)
        {
            var elements = SeleniumHelper.Wait(() => _driver.FindElements(by), seconds).Select(o => o.ToWrapper()).ToList();
            return new ReadOnlyCollection<IWebElementWrapper>(elements);
        }

        public IOptions Manage()
        {
            return _driver.Manage().ToWrapper();
        }

        public INavigation Navigate()
        {
            return _driver.Navigate().ToWrapper();
        }

        public void Quit()
        {
            _driver.Quit();
        }

        public ITargetLocatorWrapper SwitchTo()
        {
            return _driver.SwitchTo().ToWrapper();
        }
    }
}
