using DetailModule.Services;
using DetailModule.Views;
using Outlook.WPF.Infrastructure;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace DetailModule
{
    public class DetailModuleModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public DetailModuleModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
           
            _regionManager.RegisterViewWithRegion(RegionNames.DetailRegion, typeof(AllSearchDetail));
            _regionManager.RegisterViewWithRegion(RegionNames.DetailRegion, typeof(HomeDetail));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

            containerRegistry.RegisterSingleton<IGenerateAllSearchViewModel,GenerateAllSearchViewModel>();


        }
    }
}