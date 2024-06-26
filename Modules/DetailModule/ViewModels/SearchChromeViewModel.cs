﻿using DetailModule.Services;
using DetailModule.Services.interfaces;
using DetailModule.ViewModels.Interface;
using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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



        public List<CategoryModel> CategoryModels 
        {
            get;
            set;
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
            IsHavingSearchingText = false;
        }

        private readonly IGenerateCategoryModel s_generateCategoryModel = new GenerateCategoryModel();

        public SearchChromeViewModel()
        {

            CurrentViewModel = this;
            ClearSearchCommand = new DelegateCommand(ClearSearch);
            SearchCommand = new DelegateCommand<string>(Search);

            try
            {
                CategoryModels = s_generateCategoryModel.Generate().Result;
            }
            catch
            {
                MessageBox.Show("Category Error");
            }
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


        public async void OnNavigatedTo(NavigationContext navigationContext)
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
