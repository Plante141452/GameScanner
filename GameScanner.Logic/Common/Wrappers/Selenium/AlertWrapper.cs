using OpenQA.Selenium;

namespace GameScanner.Logic.Common.Wrappers.Selenium
{
    public class AlertWrapper : IAlert
    {
        private IAlert _alert;

        public AlertWrapper(IAlert alert)
        {
            _alert = alert;
        }

        public string Text
        {
            get { return _alert.Text; }
        }

        public void Accept()
        {
            _alert.Accept();
        }

        public void Dismiss()
        {
            _alert.Dismiss();
        }

        public void SendKeys(string keysToSend)
        {
            _alert.SendKeys(keysToSend);
        }

        public void SetAuthenticationCredentials(string userName, string password)
        {
            _alert.SetAuthenticationCredentials(userName, password);
        }
    }
}
