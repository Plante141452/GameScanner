using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class CookieJarWrapper : ICookieJar
    {
        private ICookieJar _cookieJar;

        public CookieJarWrapper(ICookieJar cookieJar)
        {
            _cookieJar = cookieJar;
        }

        public ReadOnlyCollection<Cookie> AllCookies
        {
            get { return _cookieJar.AllCookies; }
        }

        public void AddCookie(Cookie cookie)
        {
            _cookieJar.AddCookie(cookie);
        }

        public void DeleteAllCookies()
        {
            _cookieJar.DeleteAllCookies();
        }

        public void DeleteCookie(Cookie cookie)
        {
            _cookieJar.DeleteCookie(cookie);
        }

        public void DeleteCookieNamed(string name)
        {
            _cookieJar.DeleteCookieNamed(name);
        }

        public Cookie GetCookieNamed(string name)
        {
            return _cookieJar.GetCookieNamed(name);
        }
    }
}
