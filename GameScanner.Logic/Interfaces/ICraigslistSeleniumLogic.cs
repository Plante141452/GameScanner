using GameScanner.Logic.Common;
using System.Collections.Generic;

namespace GameScanner.Logic.Interfaces
{
    public interface ICraigslistSeleniumLogic
    {
        List<GameOffer> GetGames();
    }
}