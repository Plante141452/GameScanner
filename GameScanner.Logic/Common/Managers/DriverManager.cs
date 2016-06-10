using GameScanner.Logic.Common.Interfaces;
using GameScanner.Logic.Helpers;
using OpenQA.Selenium.Chrome;

namespace GameScanner.Logic.Common.Managers
{
    public static class DriverManager
    {
        private static ChromeDriverService ChromeDriverService;
        private static int DriverCount;

        static DriverManager()
        {
            ChromeDriverService = ChromeDriverService.CreateDefaultService(@"../../../Resources");
       }

        public static IWebDriverWrapper RequestDriver()
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
