using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Network.Http
{
    public static class ClientBase
    {

        private const string _baseAddress = "https://api.spotify.com";

        public static readonly Uri BaseUri= new Uri(_baseAddress);

        public readonly static HttpClient httpClient=new HttpClient()
        {
            BaseAddress= BaseUri
        };

    }
}
