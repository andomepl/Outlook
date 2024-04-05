using DetailModule.Services;
using DetailModule.ViewModels.Interface;
using Microsoft.Extensions.DependencyInjection;
using Outlook.WPF.Infrastructure;
using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using Outlook.WPF.SpotifyAPI.ApiServices.Artists;
using Outlook.WPF.SpotifyAPI.ApiServices.SearchItem;
using Outlook.WPF.SpotifyAPI.Models;
using Outlook.WPF.SpotifyAPI.Network;
using Outlook.WPF.SpotifyAPI.Network.Request;
using Outlook.WPF.SpotifyAPI.Network.Response;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace DetailModule.ViewModels
{
    public class AllSearchDetailViewModel:BindableBase, IFilterViewModeSearch,IClear
    {

        public static AllSearchDetailViewModel _instance=null;


        public static AllSearchDetailViewModel Get()
        {
            if (_instance == null)
                _instance = new AllSearchDetailViewModel();
            return _instance;

        }


        private AllSeachViewModel viewModel;
        public AllSeachViewModel ViewModel
        {
            get => viewModel;
            set
            {
                SetProperty(ref viewModel, value);
            }
        }

        private readonly IGenerateAllSearchViewModel s_generateAllSearchViewModel=new GenerateAllSearchViewModel();

        public AllSearchDetailViewModel()
        {
        }


        public async void Search(string s)
        {
            ViewModel = await s_generateAllSearchViewModel.GenerateAllSeachAsync(s).ConfigureAwait(false);
        }

        public void Clear()
        {
            ViewModel = null;
        }
    }
}
