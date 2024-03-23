using Outlook.WPF.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

using Outlook.WPF.Infrastructure;
using HomeModule;

namespace Outlook.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule(typeof(HomeModule.HomeModule));

            moduleCatalog.AddModule(typeof(UserLibraryModule.UserLibraryModule));

        }
    }
}
