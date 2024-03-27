using Outlook.WPF.SpotifyAPI.Network.Request;
using Outlook.WPF.SpotifyAPI.Network.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.ApiServices.SearchItem
{
    public interface ISearchItemApi
    {

        Task<SearchResponse> Search(SearchRequest s);

    }
}
