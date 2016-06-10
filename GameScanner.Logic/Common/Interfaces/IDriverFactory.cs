using GameScanner.Logic.Common.Interfaces;

namespace GameScanner.Logic.Common.Factories
{
    public interface IDriverFactory
    {
        IWebDriverWrapper CreateDriver();
    }
}