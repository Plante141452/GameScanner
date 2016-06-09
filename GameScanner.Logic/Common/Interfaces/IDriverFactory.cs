using OpenQA.Selenium;

namespace GameScanner.Logic.Common.Factories
{
    public interface IDriverFactory
    {
        IWebDriver CreateDriver();
    }
}