using Outlook.WPF.SpotifyAPI.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Network.Auth
{
    public interface IAuthentication
    {

        Task<Token> GetTokenAsync(HttpClient httpClient,string clientId,string clientSecret);

    }
}
