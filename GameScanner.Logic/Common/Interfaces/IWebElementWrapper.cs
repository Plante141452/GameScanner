using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Drawing;

namespace GameScanner.Logic.Common.Interfaces
{
    public interface IWebElementWrapper
    {
        bool Displayed { get; }
        bool Enabled { get; }
        Point Location { get; }
        bool Selected { get; }
        Size Size { get; }
        string TagName { get; }
        string Text { get; }

        void Clear();
        void Click();
        IWebElementWrapper FindElement(By by, double seconds = 10);
        ReadOnlyCollection<IWebElementWrapper> FindElements(By by, double seconds = 10);
        string GetAttribute(string attributeName);
        string GetCssValue(string propertyName);
        void SendKeys(string text);
        void Submit();
    }
}