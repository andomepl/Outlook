﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class SimpleTrack
    {
        [JsonProperty("artists")]
        public List<SimpleArtist> Artists { get; set; }


        [JsonProperty("available_markets")]
        public List<string> AvailableMarkets { get; set; }


        [JsonProperty("disc_number")]
        public int DiscNumber { get; set; }


        [JsonProperty("duration_ms")]
        public int DurationMs { get; set; }


        [JsonProperty("explicit")]
        public bool Explicit { get; set; }


        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; }


        [JsonProperty("href")]
        public string Href { get; set; }


        [JsonProperty("id")]
        public string Id { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }


        [JsonProperty("track_number")]
        public int TrackNumber { get; set; }


        [JsonProperty("type")]
        public string Type { get; set; }


        [JsonProperty("uri")]
        public string Uri { get; set; }



    }
}
