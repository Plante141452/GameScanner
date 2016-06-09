using GameScanner.Logic.Helpers;
using OpenQA.Selenium;
using System;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class TimeoutsWrapper : ITimeouts
    {
        private ITimeouts _timeouts;

        public TimeoutsWrapper(ITimeouts timeouts)
        {
            _timeouts = timeouts;
        }

        public ITimeouts ImplicitlyWait(TimeSpan timeToWait)
        {
            return _timeouts.ImplicitlyWait(timeToWait).ToWrapper();
        }

        public ITimeouts SetPageLoadTimeout(TimeSpan timeToWait)
        {
            return _timeouts.SetPageLoadTimeout(timeToWait).ToWrapper();
        }

        public ITimeouts SetScriptTimeout(TimeSpan timeToWait)
        {
            return _timeouts.SetScriptTimeout(timeToWait).ToWrapper();
        }
    }
}
