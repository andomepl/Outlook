﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class SimpleArtist
    {
        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; }


        [JsonProperty("href")]
        public string Href { get; set; }


        [JsonProperty("id")]
        public string Id { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }


        [JsonProperty("uri")]
        public string Uri { get; set; }

    }
}
