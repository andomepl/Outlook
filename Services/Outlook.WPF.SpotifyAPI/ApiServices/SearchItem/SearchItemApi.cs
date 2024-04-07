using Outlook.WPF.SpotifyAPI.Network;
using Outlook.WPF.SpotifyAPI.Network.Request;
using Outlook.WPF.SpotifyAPI.Network.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

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

            var precdentCoding= HttpUtility.UrlEncode(s.QuerySearch);

            sb.Append($"q={precdentCoding}");

            sb.Append($"&type={s.QueryType.ToString().Replace(", " , ",")}");

            sb.Append($"&limit={s.Limit}");

            sb.Append($"&offset={s.Offset}");

            string endpoint = sb.ToString();


            cancellationTokenSource.Cancel();
            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            return await Client.Get<SearchResponse?>(new Uri(endpoint), cancellationToken);

        }
    }
}
