using DetailModule.Services;
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
    public class AllSearchDetailViewModel:BindableBase,INavigationAware
    {

        private string fullSearchText = String.Empty;


        public string FullsearchText
        {
            get { return fullSearchText; }
            set
            {
                SetProperty(ref fullSearchText, value);
            }
        }


        private string profilePngPath = Outlook.WPF.Infrastructure.UserSettingData.UserDataPath+"/profile.png";

        public string ProfilePngPath
        {
            get => profilePngPath;
        }


        public ICommand ClearSearchCommand { get; }

        private AllSeachViewModel allSearchViewModel;
        public AllSeachViewModel AllSearchViewModel
        {
            get => allSearchViewModel;
            set
            {
                SetProperty(ref allSearchViewModel, value);
            }
        }

        private string accountGroupPngPath = Outlook.WPF.Infrastructure.UserSettingData.UserDataPath + "/account-Group.png";

        public string AccountGroupPngPath
        {
            get => accountGroupPngPath;
        }

        IEventAggregator _eventAggregator;

        private readonly IGenerateAllSearchViewModel s_generateAllSearchViewModel;

        public AllSearchDetailViewModel(IEventAggregator eventAggregator, IGenerateAllSearchViewModel generateAllSearchViewModel)
        {


            ClearSearchCommand = new DelegateCommand(ClearSearch);

            _eventAggregator = eventAggregator;

            SearchImplCommand = new DelegateCommand(SearchRequest);

            s_generateAllSearchViewModel = generateAllSearchViewModel;
        }

        private void ClearSearch()
        {
            FullsearchText = "";
        }

        public ICommand SearchSongsCommand { get; }


        public DelegateCommand SearchImplCommand { get; }

        public async void DefaultAllSearch()
        {


            AllSearchViewModel=await s_generateAllSearchViewModel.GenerateAllSeachAsync(FullsearchText).ConfigureAwait(false);

            //Task.Run(async () =>
            //{

            //    SearchRequest searchRequest = new SearchRequest(FullsearchText);

            //    var s = DependencyInjection.serviceProvider.GetService<ISearchItemApi>();

            //    SearchResponse sp=await s.Search(searchRequest);

            //    if (sp == null)
            //        return;

            //    if (sp.Tracks == null)
            //        return;

            //    FullTrack fullTrack= sp.Tracks.Items.First();


            //    TracksModel track = new TracksModel
            //    {
            //        Name = fullTrack.Name,
            //        ImageUri = fullTrack.Album.Images[0].Url,
            //        ArtistName=fullTrack.Artists.First().Name,
          
            //    };

            //    var fulltrackSearchTask5= sp.Tracks.Items.Take(5);


            //    ObservableCollection<TracksModel> Songs = new ObservableCollection<TracksModel>();

            //    foreach(var specifiedtrack in fulltrackSearchTask5)
            //    {
            //        Songs.Add(new TracksModel
            //        {
            //            Name=specifiedtrack.Name,
            //            ImageUri = specifiedtrack.Album.Images[0].Url,
            //            ArtistName = specifiedtrack.Artists.First().Name,
            //            Duration = TimeSpan.FromMilliseconds(specifiedtrack.DurationMs).ToString(@"mm\:ss")
            //        });
            //    }

            //    FullSearchResponseModel fullSearchResponseModel = new FullSearchResponseModel
            //    {
            //        Tracks = track,
            //        Songs = Songs
            //    };

            //    Dispatcher.CurrentDispatcher.Invoke(() =>
            //    {
            //        FullSearchResponse = fullSearchResponseModel;
            //    });

            //});

        }


        private string currentFilter = "All";

        public string CurrentFilter
        {
            get => currentFilter;
            set
            {
                SetProperty(ref currentFilter, value);
            }
        }



        public void SearchRequest()
        {

            if(CurrentFilter == "All")
            {
                DefaultAllSearch();
            }

            else if(Enum.TryParse(CurrentFilter, out QueryType result))
            {
                Task.Run(async () =>
                {

                    SearchRequest searchRequest = new SearchRequest(FullsearchText, result);

                    var s = DependencyInjection.serviceProvider.GetService<ISearchItemApi>();

                    SearchResponse sp = await s.Search(searchRequest);

                    if (sp == null)
                        return;
                });
            }


        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
