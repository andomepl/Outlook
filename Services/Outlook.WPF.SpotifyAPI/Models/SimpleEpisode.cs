using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class SimpleEpisode
    {
        [JsonProperty("audio_preview_url")]
        public string AudioPreviewUrl { get; set; } = default!;

        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        [JsonProperty("html_description")]
        public string HtmlDescription { get; set; } = default!;

        [JsonProperty("duration_ms")]
        public int DurationMs { get; set; }

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

        [JsonProperty("is_playable")]
        public bool IsPlayable { get; set; }

        [Obsolete("This field is deprecated and might be removed in the future. Please use the languages field instead")]
        public string Language { get; set; } = default!;

        [JsonProperty("languages")]
        public List<string> Languages { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; } = default!;

        [JsonProperty("release_date_precision")]
        public string ReleaseDatePrecision { get; set; } = default!;

        [JsonProperty("resume_point")]
        public ResumePoint ResumePoint { get; set; } = default!;

        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        [JsonProperty("uri")]
        public string Uri { get; set; } = default!;

        [JsonProperty("restrictions")]
        public Dictionary<string, string> Restrictions { get; set; } = default!;

    }
}
