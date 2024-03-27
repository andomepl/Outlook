using Newtonsoft.Json;
using Outlook.WPF.SpotifyAPI.Util.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Outlook.WPF.SpotifyAPI.Models
{
    public class FullAlbum
    {

        [JsonProperty("album_type")]
        public string AlbumType { get; set; } = default!;

        
        [JsonProperty("total_tracks")]
        public int TotalTracks { get; set; }



        [JsonProperty("available_markets")]
        public List<string>? AvailableMarkets { get; set; } = default!;


        [JsonProperty("external_urls")]
        public Dictionary<string, string>? ExternalUrls { get; set; } = default;



        [JsonProperty("href")]
        public string Href { get; set; } = default!;


        [JsonProperty("id")]
        public int Id { get; set; }


        [JsonProperty("images")]
        public List<Image> Images { get; set; } = default!;


        [JsonProperty("name")]
        public string Name { get; set; } = default!;


        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; } = default!;


        [JsonProperty("release_date_precision")]
        public string ReleaseDatePrecision { get; set; } = default!;


        [JsonProperty("restrictions")]
        public Dictionary<string, string>? Restrictions { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } = default!;


        [JsonProperty("uri")]
        public string Uri { get; set; } = default!;


        [JsonProperty("artists")]
        public List<SimplifiedArtist> Artists { get; set; } = default!;

        [JsonProperty("tracks")]
        public Paging<SimpleTrack> Tracks { get; set; } = default!;


        [JsonProperty("copyrights")]
        public List<Copyright> Copyrights { get; set; } = default!;

        [JsonProperty("external_ids")]
        public Dictionary<string, string> ExternalIds { get; set; } = default!;

        [JsonProperty("genres")]
        public List<string> Genres { get; set; } = default!;

        [JsonProperty("label")]
        public string Label { get; set; } = default!;

        [JsonProperty("popularity")]
        public int Popularity { get; set; } = default!;



    }
}
