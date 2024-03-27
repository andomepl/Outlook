using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class FullArtist
    {

        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; } = default!;

        [JsonProperty("followers")]
        public Followers Followers { get; set; } = default!;


        [JsonProperty("genres")]
        public List<string> Genres { get; set; } = default!;


        [JsonProperty("href")]
        public string Href { get; set; } = default!;


        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("images")]
        public List<Image> Images { get; set; } = default!;


        [JsonProperty("name")]
        public string Name { get; set; } = default!;


        [JsonProperty("popularity")]
        public int Popularity { get; set; } = default!;

        [JsonProperty("type")]
        public string Type { get; set; } = default!;


        [JsonProperty("uri")]
        public string Uri { get; set; } = default!;
    }
}
