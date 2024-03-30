﻿using Outlook.WPF.SpotifyAPI.Network;
using Outlook.WPF.SpotifyAPI.Network.Request;
using Outlook.WPF.SpotifyAPI.Network.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.ApiServices.SearchItem
{
    public class SearchItemApi : ApiBase, ISearchItemApi
    {
        public SearchItemApi(ApiClient apiClient) : base(apiClient)
        {

        }

        private const string defaultEndpoint =
            "https://api.spotify.com/v1/search?";


        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public async Task<SearchResponse?> Search(SearchRequest s)
        {
            StringBuilder sb=new StringBuilder(defaultEndpoint);

            sb.Append($"q={s.QuerySearch}");

            sb.Append($"&type={s.QueryType.ToString().Replace(", " , ",")}");

            string endpoint = sb.ToString();

            cancellationTokenSource.Cancel();

            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            return await Client.Get<SearchResponse>(new Uri(endpoint), cancellationToken);

        }
    }
}
