using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class LogsWrapper : ILogs
    {
        private ILogs _logs;

        public LogsWrapper(ILogs logs)
        {
            _logs = logs;
        }

        public ReadOnlyCollection<string> AvailableLogTypes
        {
            get { return _logs.AvailableLogTypes; }
        }

        public ReadOnlyCollection<LogEntry> GetLog(string logKind)
        {
            return _logs.GetLog(logKind);
        }
    }
}
