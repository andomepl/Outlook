using Outlook.WPF.SpotifyAPI.Models;
using Outlook.WPF.SpotifyAPI.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.ApiServices.Category
{
    public class CategoriesApi :ApiBase, ICategoriesApi
    {
        public CategoriesApi(ApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<CategoriesResponse> Get()
        {
            const string defaultEndpoint = "https://api.spotify.com/v1/browse/categories";

            Uri uri = new Uri(defaultEndpoint.ToString());

            var cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;
            return await Client.Get<CategoriesResponse>(uri, cancellationToken);
        }
    }
}
