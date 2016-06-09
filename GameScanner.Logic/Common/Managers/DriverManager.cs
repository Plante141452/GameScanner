using GameScanner.Logic.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScanner.Logic.Common.Managers
{
    public static class DriverManager
    {
        private static ChromeDriverService ChromeDriverService;
        private static int DriverCount;

        static DriverManager()
        {
            ChromeDriverService = ChromeDriverService.CreateDefaultService();
       }

        public static IWebDriver RequestDriver()
        {
            if (DriverCount == 0)
            {
                ChromeDriverService.Start();
            }

            return new ChromeDriver(ChromeDriverService).ToWrapper(); ;
        }

        public static void CloseDriver()
        {
            DriverCount--;
            if (DriverCount == 0)
                ChromeDriverService.Dispose();
        }
    }
}
