using GameScanner.Logic.Common.Wrappers.Selenium;
using OpenQA.Selenium;

namespace GameScanner.Logic.Helpers
{
    public static class SeleniumHelper
    {
        public static IWebDriver ToWrapper(this IWebDriver driver)
        {
            return new DriverWrapper(driver);
        }

        public static IWebElement ToWrapper(this IWebElement element)
        {
            return new WebElementWrapper(element);
        }

        public static IOptions ToWrapper(this IOptions options)
        {
            return new OptionsWrapper(options);
        }

        public static INavigation ToWrapper(this INavigation navigation)
        {
            return new NavigationWrapper(navigation);
        }

        public static ITargetLocator ToWrapper(this ITargetLocator targetLocator)
        {
            return new TargetLocatorWrapper(targetLocator);
        }

        public static ICookieJar ToWrapper(this ICookieJar cookieJar)
        {
            return new CookieJarWrapper(cookieJar);
        }

        public static ILogs ToWrapper(this ILogs logs)
        {
            return new LogsWrapper(logs);
        }

        public static IWindow ToWrapper(this IWindow window)
        {
            return new WindowWrapper(window);
        }

        public static ITimeouts ToWrapper(this ITimeouts timeouts)
        {
            return new TimeoutsWrapper(timeouts);
        }

        public static IAlert ToWrapper(this IAlert alert)
        {
            return new AlertWrapper(alert);
        }
    }
}
