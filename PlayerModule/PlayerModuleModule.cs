using Outlook.WPF.Infrastructure;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PlayerModule
{
    public class PlayerModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

            //containerProvider.Resolve<IRegionManager>().RegisterViewWithRegion(RegionNames.PlayerRegion,typeof(PlayerBar));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}