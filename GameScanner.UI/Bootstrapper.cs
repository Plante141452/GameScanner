using Prism.Unity;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Modules;
using HelloWorld.Views;
using GameScanner.Logic.Interfaces;
using GameScanner.Logic.SeleniumLogic;

namespace HelloWorld
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            Container.RegisterType<ICraigslistSeleniumLogic, CraigslistSeleniumLogic>();

            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(MainModule));
        }
    }
}
