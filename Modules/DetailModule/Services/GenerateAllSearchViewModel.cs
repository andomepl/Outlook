using Microsoft.Extensions.DependencyInjection;
using Outlook.WPF.Infrastructure;
using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using Outlook.WPF.SpotifyAPI.ApiServices.SearchItem;
using Outlook.WPF.SpotifyAPI.Network;
using Outlook.WPF.SpotifyAPI.Network.Request;
using Outlook.WPF.SpotifyAPI.Network.Response;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailModule.Services
{
    public class GenerateAllSearchViewModel : IGenerateAllSearchViewModel
    {
        public async Task<AllSeachViewModel> GenerateAllSeachAsync(string searchText)
        {

            AllSeachViewModel allSeachViewModel = new AllSeachViewModel();

            await Task.Run(async () =>
            {

                SearchRequest searchRequest = new SearchRequest(searchText);

                var s = DependencyInjection.serviceProvider.GetService<ISearchItemApi>();

                SearchResponse sp = await s.Search(searchRequest);

                if (sp == null)
                    return;



                TopResultModel topResultModel = new TopResultModel()
                {
                    ImageUri = sp.Tracks.Items.First().Album.Images[0].Url,
                    Name=sp.Tracks.Items.First().Name,
                    Type = sp.Tracks.Items.First().Type,
                };

                var srcSongs=sp.Tracks.Items.Skip(1).Take(4);

                ObservableCollection<TracksModel> songsModels = new ObservableCollection<TracksModel>(srcSongs.Select(s =>
                    {
                        return new TracksModel
                        {
                            AlbumName = s.Album.Name,
                            Name = s.Name,
                            ImageUri = s.Album.Images[0].Url,
                            Duration = TimeSpan.FromMilliseconds(s.DurationMs).ToString(@"mm\:ss"),
                            ArtistName = s.Artists[0].Name,
                        };
                    }
                    ));
                var artists=sp.Artists.Items.Take(5);
                ObservableCollection<ArtistsModel> artistsModels = new ObservableCollection<ArtistsModel>(artists.Select(
                        a =>
                        {
                            string imageUri = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Taylor_Swift_at_the_2023_MTV_Video_Music_Awards_%283%29.png/1280px-Taylor_Swift_at_the_2023_MTV_Video_Music_Awards_%283%29.png";
                            
                            if(a.Images.Any())
                            {
                                imageUri=a.Images[0].Url;
                            }
                            return new ArtistsModel
                            {
                                ImageUri = imageUri,
                                Name=a.Name
                            };
                        }
                    ));

                var playLists = sp.Playlists.Items.Take(5);
                ObservableCollection<PlayListsModel> playListsModels = new ObservableCollection<PlayListsModel>(playLists.Select(
                        p =>
                        {
                            return new PlayListsModel
                            {
                                ImageUri = p.Images[0].Url,
                                Name=p.Name,
                                Owner=p.Owner.DisplayName
                            };
                        }
                    ));

                allSeachViewModel.TopResultModel = topResultModel;
                allSeachViewModel.Songs = songsModels;
                allSeachViewModel.Artists = artistsModels;
                allSeachViewModel.PlayLists= playListsModels;


                return;
            });

            return allSeachViewModel;
        }
    }
}
