using Microsoft.Extensions.DependencyInjection;
using Outlook.WPF.SpotifyAPI.ApiServices;
using Outlook.WPF.SpotifyAPI.ApiServices.Artists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ApiTest
{
    public class ArtistsApiTest
    {
        private readonly ITestOutputHelper _outputHelper;

        public ArtistsApiTest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public async Task GetArtistApiTest()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSpotifyServices();

            var sb= services.BuildServiceProvider();

            try
            {
                var artistApi = sb.GetRequiredService(typeof(IArtistsApi));

                var fullArtist = await (artistApi as ArtistsApi).GetArtist("0TnOYISbd1XYRBk9myaseg");

                _outputHelper.WriteLine(fullArtist.Followers.Total.ToString());
                _outputHelper.WriteLine(fullArtist.Name);
                _outputHelper.WriteLine(fullArtist.Genres[0].ToString());
            }

            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }



            




        }

    }
}
