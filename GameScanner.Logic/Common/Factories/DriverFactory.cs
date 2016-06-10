using GameScanner.Logic.Common.Interfaces;
using GameScanner.Logic.Common.Managers;

namespace GameScanner.Logic.Common.Factories
{
    public class DriverFactory : IDriverFactory
    {
        public IWebDriverWrapper CreateDriver()
        {
            return DriverManager.RequestDriver();
        }
    }
}
