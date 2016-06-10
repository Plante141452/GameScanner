using System;
using System.Collections.Generic;
using GameScanner.Logic.Common;
using GameScanner.Logic.Interfaces;
using GameScanner.Logic.Common.Factories;
using OpenQA.Selenium;
using System.Threading;
using System.Linq;
using GameScanner.Logic.Common.Interfaces;

namespace GameScanner.Logic.Craigslist
{
    public class CraigslistSeleniumLogic : ICraigslistSeleniumLogic
    {
        private IDriverFactory _driverFactory;
        private IWebDriverWrapper _mainDriver;

        public CraigslistSeleniumLogic(IDriverFactory driverFactory)
        {
            _driverFactory = driverFactory;
        }

        public List<GameOffer> GetGames()
        {
            _mainDriver = _driverFactory.CreateDriver();
            _mainDriver.Navigate().GoToUrl("https://cleveland.craigslist.org/search/vga");

            _mainDriver.FindElement(By.XPath("//ul[@class='dropdown-list']")).Click();
            _mainDriver.FindElement(By.XPath("//li[@class='dropdown-item mode sel' and button[@data-view='list']]")).Click();

            var elements = _mainDriver.FindElements(By.XPath("//div[@class='rows']/p[@class='row']"));

            var GameOffers = elements.Select(element =>
            {
                double costDouble;

                try
                {
                    string cost = element.FindElement(By.XPath(".//span[@class='l2']/span[@class='price']"), .1d).Text.Trim('$');
                    if (!double.TryParse(cost, out costDouble))
                        costDouble = -1;
                }
                catch
                {
                    costDouble = -1;
                }
                
                return new GameOffer
                {
                    Name = element.FindElement(By.XPath(".//span[@id='titletextonly']")).Text,
                    Cost = costDouble
                };
            }).ToList();

            //div[@class='rows']/p//span[@id='titletextonly']

            Thread.Sleep(10000);

            _mainDriver.Close();

            return new List<GameOffer>();
        }
    }
}
