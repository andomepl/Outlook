using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class SimpleShow
    {
        [JsonProperty("available_markets")]
        public List<string> AvailableMarkets { get; set; } = default!;

        [JsonProperty("copyrights")]
        public List<Copyright> Copyrights { get; set; } = default!;

        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        [JsonProperty("html_description")]
        public string HtmlDescription { get; set; } = default!;
        [JsonProperty("explicit")]
        public bool Explicit { get; set; }

        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; } = default!;

        [JsonProperty("href")]
        public string Href { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("images")]
        public List<Image> Images { get; set; } = default!;

        [JsonProperty("is_externally_hosted")]
        public bool IsExternallyHosted { get; set; }

        [JsonProperty("languages")]
        public List<string> Languages { get; set; } = default!;

        [JsonProperty("media_type")]
        public string MediaType { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("publisher")]
        public string Publisher { get; set; } = default!;

        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        [JsonProperty("uri")]
        public string Uri { get; set; } = default!;

        [JsonProperty("total_episodes")]
        public int TotalEpisodes { get; set; } = default!;
    }
}
