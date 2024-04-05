using DetailModule.Services;
using DetailModule.ViewModels;
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

            var searchChrome= containerProvider.Resolve<SearchChrome>();
            _regionManager.AddToRegion(RegionNames.DetailRegion, searchChrome);
            var homeDetail = containerProvider.Resolve<HomeDetail>();
            _regionManager.AddToRegion(RegionNames.DetailRegion, homeDetail);

            _regionManager.Regions[RegionNames.DetailRegion].Activate(homeDetail);


        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

            containerRegistry.RegisterSingleton<IGenerateAllSearchViewModel,GenerateAllSearchViewModel>();


            containerRegistry.RegisterSingleton<AllSearchDetailViewModel>();
            containerRegistry.RegisterSingleton<WithFilterSearchChromeViewModel>();


        }
    }
}