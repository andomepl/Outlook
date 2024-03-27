using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class SimplePlaylist
    {
        [JsonProperty("collaborative")]
        public bool? Collaborative { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; } = default!;

        [JsonProperty("external_urls")]
        public Dictionary<string, string>? ExternalUrls { get; set; } = default!;

        [JsonProperty("href")]
        public string? Href { get; set; } = default!;

        [JsonProperty("id")]
        public string? Id { get; set; } = default!;

        [JsonProperty("images")]
        public List<Image>? Images { get; set; } = default!;

        [JsonProperty("name")]
        public string? Name { get; set; } = default!;

        [JsonProperty("owner")]
        public PlaylistOwner? Owner { get; set; } = default!;

        [JsonProperty("public")]
        public bool? Public { get; set; }

        [JsonProperty("snapshot_id")]
        public string? SnapshotId { get; set; } = default!;

        [JsonProperty("tracks")]
        public Dictionary<string,string> Tracks { get; set; } = default!;

        [JsonProperty("type")]
        public string? Type { get; set; } = default!;

        [JsonProperty("uri")]
        public string? Uri { get; set; } = default!;
    }
}
