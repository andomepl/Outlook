using Outlook.WPF.Infrastructure;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HomeModule.ViewModels
{
    public class homeViewModel:BindableBase
    {

        private bool isHomeBtnChecked=false;

        public bool IsHomeBtnChecked
        {
            get => isHomeBtnChecked;
            set
            {
                if (IsSearchBtnChecked == true)
                    IsSearchBtnChecked = false;
                SetProperty(ref isHomeBtnChecked, value);
            }
        }

        private readonly IRegionManager _regionManager;

        public homeViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NaviHome = new DelegateCommand(naviHome);

            NaviSearch = new DelegateCommand(naviSearch);
        }


        private bool isSearchBtnChecked = false;

        public bool IsSearchBtnChecked
        {
            get => isSearchBtnChecked;
            set
            {
                if(IsHomeBtnChecked==true)
                    IsHomeBtnChecked = false;

                SetProperty(ref isSearchBtnChecked, value);
            }
        }


        public ICommand NaviHome { get; }

        public ICommand NaviSearch { get; }

        private void naviHome()
        {
            _regionManager.RequestNavigate(RegionNames.DetailRegion, "HomeDetail");
        }

        private void naviSearch()
        {
            _regionManager.RequestNavigate(RegionNames.DetailRegion, "DefaultSearchView");
        }

    }
}
