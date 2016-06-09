using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using GameScanner.Logic.Common.Managers;

namespace GameScanner.Logic.Common.Factories
{
    public class DriverFactory : IDriverFactory
    {
        public IWebDriver CreateDriver()
        {
            return DriverManager.RequestDriver();
        }
    }
}
