using DetailModule.ViewModels.Interface;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DetailModule.ViewModels
{
    public class SearchChromeViewModel:BindableBase,INavigationAware
    {

        private object currentViewModel;
        public object CurrentViewModel 
        { 
            get=>currentViewModel;
            set
            {
                SetProperty(ref currentViewModel, value);
            } 
        }


        private string accountGroupPngPath = Outlook.WPF.Infrastructure.UserSettingData.UserDataPath + "/account-Group.png";

        public string AccountGroupPngPath
        {
            get => accountGroupPngPath;
        }

        private string profilePngPath = Outlook.WPF.Infrastructure.UserSettingData.UserDataPath + "/profile.png";

        public string ProfilePngPath
        {
            get => profilePngPath;
        }


        private string fullSearchText;

        public string FullsearchText
        {
            get => fullSearchText;
            set
            {

                SetProperty(ref fullSearchText, value);
            }
        }

        private bool isHavingSearchingText=false;

        public bool IsHavingSearchingText
        {
            get => isHavingSearchingText;
            set
            {
                if(isHavingSearchingText==false&&value==true) 
                {
                    CurrentViewModel = WithFilterSearchChromeViewModel.Get();
                    isHavingSearchingText = value;
                }

                if(isHavingSearchingText == true&&value==false)
                {
                    CurrentViewModel = this;
                    isHavingSearchingText = value;
                }
            }
        }


        public ICommand ClearSearchCommand { get; }

        private void ClearSearch()
        {
            FullsearchText = "";
        }

        public SearchChromeViewModel()
        {

            CurrentViewModel = this;
            ClearSearchCommand = new DelegateCommand(ClearSearch);

            SearchCommand = new DelegateCommand<string>(Search);


        }

        public DelegateCommand<string> SearchCommand { get; }

        private void Search(string searchText)
        {
            if (searchText == null)
                return;
            if(CurrentViewModel is IFilterViewModeSearch ifilter)
            {
                ifilter.Search(searchText);
            }
            
        }


        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            CurrentViewModel = this;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            FullsearchText = string.Empty;
            IsHavingSearchingText = false;
            CurrentViewModel = null;
            return;
        }
    }
}
