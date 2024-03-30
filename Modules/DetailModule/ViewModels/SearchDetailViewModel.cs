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
    public class SearchDetailViewModel:BindableBase,INavigationAware
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

        private FullSearchResponseModel fullSearchResponse;

        public FullSearchResponseModel FullSearchResponse
        {
            get => fullSearchResponse;
            set
            {
                SetProperty(ref fullSearchResponse, value);

                
            }
        }

        private string accountGroupPngPath = Outlook.WPF.Infrastructure.UserSettingData.UserDataPath + "/account-Group.png";

        public string AccountGroupPngPath
        {
            get => accountGroupPngPath;
        }


        private TimeSpan searchTimeSpan = TimeSpan.FromSeconds(2);


        IEventAggregator _eventAggregator;



        public SearchDetailViewModel(IEventAggregator eventAggregator)
        {

            ClearSearchCommand = new DelegateCommand(ClearSearch);

            _eventAggregator = eventAggregator;

        }

        private void ClearSearch()
        {
            FullsearchText = "";
        }

        public ICommand SearchSongsCommand { get; }
        private void SearchSongs()
        {
            Task.Run(async () =>
            {

                SearchRequest searchRequest = new SearchRequest(FullsearchText,QueryType.track);

                var s = DependencyInjection.serviceProvider.GetService<ISearchItemApi>();

                SearchResponse sp = await s.Search(searchRequest);

                if (sp.Tracks == null)
                    return;

                FullTrack fullTrack = sp.Tracks.Items.First();

                TracksModel track = new TracksModel
                {
                    Name = fullTrack.Name,
                    ImageUri = fullTrack.Album.Images[0].Url,
                    DisplayType = fullTrack.Type,
                    Artists = new ArtistsModel
                    {
                        Name = fullTrack.Artists.First().Name
                    }

                };

                var fulltrackSearchTask5 = sp.Tracks.Items.Take(5);


                ObservableCollection<TracksModel> Songs = new ObservableCollection<TracksModel>();

                foreach (var specifiedtrack in fulltrackSearchTask5)
                {
                    Songs.Add(new TracksModel
                    {
                        Name = specifiedtrack.Name,
                        ImageUri = specifiedtrack.Album.Images[0].Url,
                        Artists = new ArtistsModel()
                        {
                            Name = specifiedtrack.Artists.First().Name
                        },
                        Duration = TimeSpan.FromMilliseconds(specifiedtrack.DurationMs).ToString(@"mm\:ss")
                    });
                }

                FullSearchResponseModel fullSearchResponseModel = new FullSearchResponseModel
                {
                    Tracks = track,
                    Songs = Songs
                };

                Dispatcher.CurrentDispatcher.Invoke(() =>
                {
                    FullSearchResponse = fullSearchResponseModel;
                });

            });
        }


        public void DisMessage()
        {

            Task.Run(async () =>
            {

                SearchRequest searchRequest = new SearchRequest(FullsearchText);

                var s = DependencyInjection.serviceProvider.GetService<ISearchItemApi>();

                SearchResponse sp=await s.Search(searchRequest);

                if (sp == null)
                    return;

                if (sp.Tracks == null)
                    return;

                FullTrack fullTrack= sp.Tracks.Items.First();

                TracksModel track = new TracksModel
                {
                    Name = fullTrack.Name,
                    ImageUri = fullTrack.Album.Images[0].Url,
                    DisplayType = fullTrack.Type,
                    Artists = new ArtistsModel
                    {
                        Name = fullTrack.Artists.First().Name
                    }

                };

                var fulltrackSearchTask5= sp.Tracks.Items.Take(5);


                ObservableCollection<TracksModel> Songs = new ObservableCollection<TracksModel>();

                foreach(var specifiedtrack in fulltrackSearchTask5)
                {
                    Songs.Add(new TracksModel
                    {
                        Name=specifiedtrack.Name,
                        ImageUri = specifiedtrack.Album.Images[0].Url,
                        Artists=new ArtistsModel()
                        {
                             Name=specifiedtrack.Artists.First().Name
                        },
                        Duration= TimeSpan.FromMilliseconds(specifiedtrack.DurationMs).ToString(@"mm\:ss")
                    });
                }

                FullSearchResponseModel fullSearchResponseModel = new FullSearchResponseModel
                {
                    Tracks = track,
                    Songs = Songs
                };

                Dispatcher.CurrentDispatcher.Invoke(() =>
                {
                    FullSearchResponse = fullSearchResponseModel;
                });

            });

            

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
