using DetailModule.Services.interfaces;
using Outlook.WPF.Infrastructure;
using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using Outlook.WPF.SpotifyAPI.ApiServices.SearchItem;
using Outlook.WPF.SpotifyAPI.Network.Request;
using Outlook.WPF.SpotifyAPI.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DetailModule.Services
{
    public class GenerateSearchSongsModel : IGenerateSearchSongsModel
    {
        public async Task<List<TracksModel>> Generate(string searchText)
        {
            List<TracksModel> tracksModels = new List<TracksModel>();

            await Task.Run(async () =>
            {
                var service = DependencyInjection.serviceProvider.GetService<ISearchItemApi>();

                SearchRequest searchRequest = new SearchRequest(searchText, QueryType.track,limit:50,offset:0);

                var response = await service.Search(searchRequest);

                if (response == null)
                    return;

                tracksModels.AddRange(response.Tracks.Items.
                            Select(t =>
                            {
                                string imageUri = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Taylor_Swift_at_the_2023_MTV_Video_Music_Awards_%283%29.png/1280px-Taylor_Swift_at_the_2023_MTV_Video_Music_Awards_%283%29.png";
                                if (t.Album.Images.Any())
                                {
                                    imageUri = t.Album.Images[0].Url;
                                }

                                return new TracksModel { Name = t.Name, ImageUri = imageUri, AlbumName=t.Album.Name, ArtistName = t.Artists[0].Name, Duration= TimeSpan.FromMilliseconds(t.DurationMs).ToString(@"mm\:ss") }; 
                            }
                            ));

            });

            return tracksModels;
        }
    }
}
