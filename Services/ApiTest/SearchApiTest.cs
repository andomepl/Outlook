using Microsoft.Extensions.DependencyInjection;
using Outlook.WPF.SpotifyAPI.ApiServices;
using Outlook.WPF.SpotifyAPI.ApiServices.Artists;
using Outlook.WPF.SpotifyAPI.ApiServices.SearchItem;
using Outlook.WPF.SpotifyAPI.Network;
using Outlook.WPF.SpotifyAPI.Network.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace ApiTest
{
    public class SearchApiTest
    {

        private readonly ITestOutputHelper _outputHelper;

        public SearchApiTest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public async void SearchArtists()
        {

            IServiceCollection services = new ServiceCollection();

            services.AddSpotifyServices();

            var sb = services.BuildServiceProvider();

            try
            {
                var searchApi = sb.GetRequiredService(typeof(ISearchItemApi));

                SearchRequest searchRequest = new SearchRequest("lady Gaga",QueryType.artist);

                var searchResponse = await (searchApi as SearchItemApi).Search(searchRequest);

                _outputHelper.WriteLine(searchResponse.Artists.Items[0].Images[0].Url);

            }

            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

        [Fact]
        public async void SearchAlbum()
        {

            IServiceCollection services = new ServiceCollection();

            services.AddSpotifyServices();

            var sb = services.BuildServiceProvider();

            try
            {
                var searchApi = sb.GetRequiredService(typeof(ISearchItemApi));

                SearchRequest searchRequest = new SearchRequest("lovestory",QueryType.album);

                var searchResponse =await (searchApi as SearchItemApi).Search(searchRequest);

                _outputHelper.WriteLine(searchResponse.Albums.Items[0].Name);

            }

            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

        [Fact]
        public async void SearchTrack()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSpotifyServices();

            var sb = services.BuildServiceProvider();

            try
            {
                var searchApi = sb.GetRequiredService(typeof(ISearchItemApi));

                SearchRequest searchRequest = new SearchRequest("lovestory", QueryType.track);

                var searchResponse = await (searchApi as SearchItemApi).Search(searchRequest);

                _outputHelper.WriteLine(searchResponse.Tracks.Items[0].Album.Images[0].Url);

            }

            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Fact]
        public async void SearchPlaylist()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSpotifyServices();

            var sb = services.BuildServiceProvider();

            try
            {
                var searchApi = sb.GetRequiredService(typeof(ISearchItemApi));

                SearchRequest searchRequest = new SearchRequest("lovestory", QueryType.playlist);

                var searchResponse = await (searchApi as SearchItemApi).Search(searchRequest);

                _outputHelper.WriteLine(searchResponse.Playlists.Items[0].Owner.DisplayName);

            }

            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Fact]
        public async void SearchFull()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSpotifyServices();

            var sb = services.BuildServiceProvider();

            try
            {
                var searchApi = sb.GetRequiredService(typeof(ISearchItemApi));

                SearchRequest searchRequest = new SearchRequest("lovestory");

                var searchResponse = await (searchApi as SearchItemApi).Search(searchRequest);

                _outputHelper.WriteLine(searchResponse.ToString());

            }

            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
