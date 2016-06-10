using OpenQA.Selenium;
using System.Linq;
using System.Collections.ObjectModel;
using System.Drawing;
using GameScanner.Logic.Helpers;
using GameScanner.Logic.Common.Interfaces;
using System.Collections.Generic;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class WebElementWrapper : IWebElementWrapper
    {
        private IWebElement _element;

        public WebElementWrapper(IWebElement element)
        {
            _element = element;
        }

        public bool Displayed
        {
            get { return _element.Displayed; }
        }

        public bool Enabled
        {
            get { return _element.Enabled; }
        }

        public Point Location
        {
            get { return _element.Location; }
        }

        public bool Selected
        {
            get { return _element.Selected; }
        }

        public Size Size
        {
            get { return _element.Size; }
        }

        public string TagName
        {
            get { return _element.TagName; }
        }

        public string Text
        {
            get { return _element.Text; }
        }

        public void Clear()
        {
            _element.Clear();
        }

        public void Click()
        {
            _element.Click();
        }

        public IWebElementWrapper FindElement(By by, double seconds = 10)
        {
            return SeleniumHelper.Wait(() => _element.FindElement(by), seconds).ToWrapper();
        }

        public ReadOnlyCollection<IWebElementWrapper> FindElements(By by, double seconds = 10)
        {
            IList<IWebElementWrapper> elements = SeleniumHelper.Wait(() => _element.FindElements(by), seconds).Select(o => o.ToWrapper()).ToList();
            return new ReadOnlyCollection<IWebElementWrapper>(elements);
        }

        public string GetAttribute(string attributeName)
        {
            return _element.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return _element.GetCssValue(propertyName);
        }

        public void SendKeys(string text)
        {
            _element.SendKeys(text);
        }

        public void Submit()
        {
            _element.Submit();
        }
    }
}
