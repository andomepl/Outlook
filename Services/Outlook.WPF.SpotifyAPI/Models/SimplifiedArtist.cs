using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class SimplifiedArtist
    {
        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; } = default!;

        [JsonProperty("href")]
        public string Href { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        [JsonProperty("uri")]
        public string Uri { get; set; } = default!;

    }
}
