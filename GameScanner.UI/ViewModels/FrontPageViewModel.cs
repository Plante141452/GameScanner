using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;
using System;
using GameScanner.Logic.Interfaces;

namespace GameScanner.UI.ViewModels
{
    public class FrontPageViewModel : BindableBase
    {
        private ICraigslistSeleniumLogic _clSeleniumLogic;

        public FrontPageViewModel(ICraigslistSeleniumLogic clSeleniumLogic)
        {
            _clSeleniumLogic = clSeleniumLogic;
        }
        
        public string FindGamesText
        {
            get { return "Find Games"; }
        }

        #region Find Games Command

        private DelegateCommand _findGames;
        public ICommand FindGamesCommand
        {
            get { return _findGames ?? (_findGames = new DelegateCommand(FindGames)); }
        }

        private void FindGames()
        {
            _clSeleniumLogic.GetGames();
        }

        #endregion
    }
}
