using OpenQA.Selenium;
using System.Linq;
using System.Collections.ObjectModel;
using GameScanner.Logic.Helpers;
using GameScanner.Logic.Common.Managers;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class DriverWrapper : IWebDriver
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

        public IWebElement FindElement(By by)
        {
            return _driver.FindElement(by).ToWrapper();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return new ReadOnlyCollection<IWebElement>(_driver.FindElements(by).Select(o => o.ToWrapper()).ToList());
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

        public ITargetLocator SwitchTo()
        {
            return _driver.SwitchTo().ToWrapper();
        }
    }
}
