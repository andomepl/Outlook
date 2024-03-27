using Outlook.WPF.SpotifyAPI.Models;
using Outlook.WPF.SpotifyAPI.Network;
using Outlook.WPF.SpotifyAPI.Network.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.ApiServices.Artists
{
    public class ArtistsApi : ApiBase, IArtistsApi
    {
        public ArtistsApi(ApiClient apiClient) : base(apiClient)
        {

        }


        public async Task<FullArtist> GetArtist(string id)
        {

            const string defaultEndpoint = "https://api.spotify.com/v1/artists";

            StringBuilder stringBuilder = new StringBuilder(defaultEndpoint);
            stringBuilder.Append($"/{id}");

            Uri uri = new Uri(stringBuilder.ToString());

            return await Client.Get<FullArtist>(uri,new CancellationToken());
        }

    }
}
