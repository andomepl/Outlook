using HomeModule.Views;
using Outlook.WPF.Infrastructure;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace HomeModule
{
    public class HomeModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public HomeModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.HomeRegion, typeof(home));
            
        }


        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}