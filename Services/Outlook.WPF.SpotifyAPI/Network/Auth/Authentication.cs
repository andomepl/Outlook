using Newtonsoft.Json;
using Outlook.WPF.SpotifyAPI.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Network.Auth
{
    public class Authentication : IAuthentication
    {

        private const string defalutEndpoint = "https://accounts.spotify.com/api/token";

        public async Task<Token> GetTokenAsync(HttpClient httpClient, string clientId, string clientSecret)
        {

            string auth=Convert.ToBase64String(Encoding.UTF8.GetBytes(clientId+":"+clientSecret));

            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + auth);


            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")

            };

            HttpContent content = new FormUrlEncodedContent(args);


            HttpResponseMessage authenResponse=await httpClient.PostAsync(defalutEndpoint, content);

            string tokens=await authenResponse.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Token>(tokens);
        }
    }
}
