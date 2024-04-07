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
    public class GenerateSearchPlayListsModel : IGenerateSearchPlayListsModel
    {
        public async Task<List<PlayListsModel>> Generate(string searchText)
        {
            List<PlayListsModel> playListsModels = new List<PlayListsModel>();

            await Task.Run(async () =>
            {

                var service = DependencyInjection.serviceProvider.GetService<ISearchItemApi>();

                SearchRequest searchRequest = new SearchRequest(searchText, QueryType.playlist);

                var response = await service.Search(searchRequest);

                if (response == null)
                    return;

                playListsModels.AddRange(response.Playlists.Items.
                        Select(p =>
                        {
                            string imageUri = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Taylor_Swift_at_the_2023_MTV_Video_Music_Awards_%283%29.png/1280px-Taylor_Swift_at_the_2023_MTV_Video_Music_Awards_%283%29.png";
                            if (p.Images.Any())
                            {
                                imageUri = p.Images[0].Url;
                            }

                            return new PlayListsModel { Name = p.Name, ImageUri = imageUri,Owner=p.Owner.DisplayName };
                        }
                        ));

            });

            return playListsModels;
        }
    }
}
