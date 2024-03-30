using Newtonsoft.Json;
using Outlook.WPF.SpotifyAPI.Models.Authentication;
using Outlook.WPF.SpotifyAPI.Network.Auth;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Network
{
    public class ApiClient:ICRUD
    {

        public const string baseAddress = "https://api.spotify.com/v1";
        public static HttpClient httpClient { get; set; } = new HttpClient();

        private const string ClientId = "bd3502eff80c40b4b8d99eff0bb27e31";

        private const string ClientSecret = "cb327a49f7c9433ca6bf35a436867f2a";

        private Token token;

        public Token Credential
        {
            get => token;
        }

     

        public ApiClient()
        {
            Task.Run(async () =>
            {
                await AuthenInitAsync();

                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {Credential.AccessToken}");

                //httpClient.Timeout = TimeSpan.FromMilliseconds(5000);

            }).Wait();
        }

        private async Task AuthenInitAsync()
        {

            IAuthentication authentication = new Authentication();
            token = await authentication.GetTokenAsync(httpClient, ClientId, ClientSecret);
        }




        public async Task<T?> Get<T>(Uri uri,CancellationToken cancelToken)
        {
            try
            {

                HttpResponseMessage response = await httpClient.GetAsync(uri, cancelToken);
                string entity = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(entity);
            }

            catch(OperationCanceledException e)
            {
                Debug.WriteLine("Last Request was canceled "+e.Message);
            }

            return default(T);
            
        }



    }
}
