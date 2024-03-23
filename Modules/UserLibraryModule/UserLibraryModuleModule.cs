using Outlook.WPF.Infrastructure;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using UserLibraryModule.Views;

namespace UserLibraryModule
{
    public class UserLibraryModule : IModule
    {

        private readonly IRegionManager _regionManager;

        public UserLibraryModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.UserLibraryRegion, typeof(LibraryView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}