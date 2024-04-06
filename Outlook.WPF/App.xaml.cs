using Outlook.WPF.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

using Outlook.WPF.Infrastructure;
using HomeModule;
using Microsoft.Extensions.DependencyInjection;
using Outlook.WPF.SpotifyAPI.ApiServices;
using System.Linq.Expressions;
using System;

namespace Outlook.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {

        protected override void InitializeModules()
        {
            var splashScreen=new SplashScreen("./Assets/icons/dog.png");
            splashScreen.Show(false);
            try{
                base.InitializeModules();
            }
            finally
            {
                splashScreen.Close(TimeSpan.Zero);
            }
            
            
        }


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
            moduleCatalog.AddModule(typeof(DetailModule.DetailModuleModule));
        }
    }
}
