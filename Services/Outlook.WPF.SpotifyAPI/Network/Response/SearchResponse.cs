using Newtonsoft.Json;
using Outlook.WPF.SpotifyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Network.Response
{
    public class SearchResponse
    {
        [JsonProperty("tracks")]
        public Paging<FullTrack, SearchResponse> Tracks { get; set; } = default!;

        [JsonProperty("artists")]
        public Paging<FullArtist, SearchResponse> Artists { get; set; } = default!;

        [JsonProperty("albums")]
        public Paging<SimpleAlbum, SearchResponse> Albums { get; set; } = default!;

        [JsonProperty("playlists")]
        public Paging<SimplePlaylist, SearchResponse> Playlists { get; set; } = default!;

        [JsonProperty("shows")]
        public Paging<SimpleShow, SearchResponse> Shows { get; set; } = default!;

        [JsonProperty("episodes")]
        public Paging<SimpleEpisode, SearchResponse> Episodes { get; set; } = default!;

    }

}
