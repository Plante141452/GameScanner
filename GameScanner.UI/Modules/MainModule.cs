using GameScanner.UI.Views;
using Prism.Modularity;
using Prism.Regions;

namespace Modules
{
    public class MainModule : IModule
    {
        IRegionManager _regionManager;

        public MainModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(FrontPage));
        }
    }
}
