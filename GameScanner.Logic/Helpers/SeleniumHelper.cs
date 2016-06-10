using GameScanner.Logic.Common.Interfaces;
using GameScanner.Logic.Common.Wrappers.Selenium;
using OpenQA.Selenium;
using System;

namespace GameScanner.Logic.Helpers
{
    public static class SeleniumHelper
    {
        #region Wrappers

        public static IWebDriverWrapper ToWrapper(this IWebDriver driver)
        {
            return new DriverWrapper(driver);
        }

        public static IWebElementWrapper ToWrapper(this IWebElement element)
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

        public static ITargetLocatorWrapper ToWrapper(this ITargetLocator targetLocator)
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

        #endregion

        public static T Wait<T>(Func<T> exec, double seconds)
        {
            DateTime startTime = DateTime.Now;
            TimeSpan waitTime = TimeSpan.FromSeconds(seconds);
            while (DateTime.Now.Subtract(startTime) < waitTime)
            {
                try
                {
                    return exec();
                }
                catch
                {
                    //Do Nothing
                }
            }
            throw new Exception(string.Format("Waited {0} seconds but could event did not occur", seconds));
        }
    }
}
