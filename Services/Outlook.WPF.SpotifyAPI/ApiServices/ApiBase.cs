using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook.WPF.SpotifyAPI.Network;

namespace Outlook.WPF.SpotifyAPI.ApiServices
{
    public abstract class ApiBase
    {

        protected ApiClient Client { get; set; }


        public ApiBase(ApiClient apiClient)
        {
            Client = apiClient;
        }



    }
}
