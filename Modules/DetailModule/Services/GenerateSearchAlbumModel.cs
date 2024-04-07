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
    public class GenerateSearchAlbumModel : IGenerateSearchAlbumViewModel
    {
        public async Task<List<AlbumModel>> Generate(string searchText)
        {
            List<AlbumModel> albumModels = new List<AlbumModel>();

            await Task.Run(async() =>
            {
                var service = DependencyInjection.serviceProvider.GetService<ISearchItemApi>();

                SearchRequest searchRequest = new SearchRequest(searchText, QueryType.album);

                var response = await service.Search(searchRequest);

                if (response == null)
                    return;

                albumModels.AddRange(response.Albums.Items.Select(a =>
                {

                    return new AlbumModel { Name=a.Name, ReleaseDate = a.ReleaseDate, ArtistName = a.Artists[0].Name, ImageUri = a.Images[0].Url };
                }
                ));

            });

            return albumModels;
        }
    }
}
