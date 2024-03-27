using Outlook.WPF.SpotifyAPI.Network;
using System.Diagnostics;
using Xunit.Abstractions;

namespace ApiTest
{
    public class UnitTest1
    {

        private readonly ITestOutputHelper _outputHelper;

        public UnitTest1(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void ApiClient()
        {
            ApiClient apiClient = new ApiClient();
            var credential = apiClient.Credential;

            _outputHelper.WriteLine(credential.AccessToken);
            _outputHelper.WriteLine(credential.TokenType);
            _outputHelper.WriteLine(credential.ExpiresIn);
        }

    }
}