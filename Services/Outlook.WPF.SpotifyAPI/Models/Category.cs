using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class Category
    {

        [JsonProperty("href")]
        public string Href { get; set; } = default!;

        [JsonProperty("icons")]
        public List<Image> Icons { get; set; } = default!;

        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        [JsonProperty("name")]
        public string Name { get; set; } = default!;
    }
}
