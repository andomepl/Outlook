using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class FullTrack
    {

        [JsonProperty("album")]
        public SimpleAlbum Album { get; set; } = default!;

        [JsonProperty("artists")]
        public List<SimpleArtist> Artists { get; set; } = default!;
        [JsonProperty("available_markets")]
        public List<string> AvailableMarkets { get; set; } = default!;

        [JsonProperty("disc_number")]
        public int DiscNumber { get; set; }

        [JsonProperty("duration_ms")]
        public int DurationMs { get; set; }

        [JsonProperty("explicit")]
        public bool Explicit { get; set; }

        [JsonProperty("external_ids")]
        public Dictionary<string, string> ExternalIds { get; set; } = default!;

        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; } = default!;

        [JsonProperty("href")]
        public string Href { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("is_playable")]
        public bool IsPlayable { get; set; } = default!;

        [JsonProperty("linked_from")]
        public LinkedTrack LinkedFrom { get; set; } = default!;

        [JsonProperty("restrictions")]
        public Dictionary<string, string> Restrictions { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; } = default!;

        [JsonProperty("track_number")]
        public int TrackNumber { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        [JsonProperty("uri")]
        public string Uri { get; set; } = default!;

        [JsonProperty("is_local")]
        public bool IsLocal { get; set; } = default!;

    }
}
