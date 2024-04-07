using DetailModule.Services.interfaces;
using Microsoft.Extensions.DependencyInjection;
using Outlook.WPF.Infrastructure;
using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using Outlook.WPF.SpotifyAPI.ApiServices.Category;
using Outlook.WPF.SpotifyAPI.ApiServices.SearchItem;
using Outlook.WPF.SpotifyAPI.Network;
using Outlook.WPF.SpotifyAPI.Network.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DetailModule.Services
{
    public class GenerateSearchArtistsModel : IGenerateSearchArtistsModel
    {
        public async Task<List<ArtistsModel>> Generate(string searchText)
        {
            List<ArtistsModel> artistsModels = new List<ArtistsModel>();
            await Task.Run(async () =>
            {
                var service = DependencyInjection.serviceProvider.GetService<ISearchItemApi>();

                SearchRequest searchRequest = new SearchRequest(searchText,QueryType.artist);

                var response = await service.Search(searchRequest);

                if (response == null)
                    return;

                artistsModels.AddRange(response.Artists.Items.
                            Select(a =>
                            {
                                string imageUri= "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Taylor_Swift_at_the_2023_MTV_Video_Music_Awards_%283%29.png/1280px-Taylor_Swift_at_the_2023_MTV_Video_Music_Awards_%283%29.png";
                                if (a.Images.Any())
                                {
                                    imageUri = a.Images[0].Url;
                                }

                                return new ArtistsModel { Name = a.Name, ImageUri = imageUri };
                            }
                            ));
            });

            return artistsModels;
        }
    }
}
