using GameScanner.Logic.Helpers;
using OpenQA.Selenium;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class OptionsWrapper : IOptions
    {
        private IOptions _options;

        public OptionsWrapper(IOptions options)
        {
            _options = options;
        }

        public ICookieJar Cookies
        {
            get { return _options.Cookies.ToWrapper(); }
        }

        public ILogs Logs
        {
            get { return _options.Logs.ToWrapper(); }
        }

        public IWindow Window
        {
            get { return _options.Window.ToWrapper(); }
        }

        public ITimeouts Timeouts()
        {
            return _options.Timeouts().ToWrapper();
        }
    }
}
