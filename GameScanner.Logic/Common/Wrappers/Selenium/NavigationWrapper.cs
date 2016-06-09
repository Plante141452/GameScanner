using OpenQA.Selenium;
using System;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class NavigationWrapper : INavigation
    {
        private INavigation _navigation;

        public NavigationWrapper(INavigation navigation)
        {
            _navigation = navigation;
        }

        public void Back()
        {
            _navigation.Back();
        }

        public void Forward()
        {
            _navigation.Forward();
        }

        public void GoToUrl(Uri url)
        {
            _navigation.GoToUrl(url);
        }

        public void GoToUrl(string url)
        {
            _navigation.GoToUrl(url);
        }

        public void Refresh()
        {
            _navigation.Refresh();
        }
    }
}
