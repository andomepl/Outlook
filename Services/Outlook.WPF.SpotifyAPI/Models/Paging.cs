using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class Paging<T>:IPaginatable<T>
    {

        [JsonProperty("href")]
        public string? Href { get; set; } = default!;

        [JsonProperty("items")]
        public List<T>? Items { get; set; } = default!;

        [JsonProperty("limit")]
        public int? Limit { get; set; } = default!;

        [JsonProperty("next")]
        public string? Next { get; set; } = default!;
        [JsonProperty("offset")]
        public int? Offset { get; set; } = default!;
        [JsonProperty("previous")]
        public string? Previous { get; set; } = default!;
        [JsonProperty("total")]
        public int? Total { get; set; } = default!;

    }


    public class Paging<T, TNext> : IPaginatable<T, TNext>
    {
        [JsonProperty("href")]
        public string? Href { get; set; } = default!;

        [JsonProperty("items")]
        public List<T>? Items { get; set; } = default!;

        [JsonProperty("limit")]
        public int? Limit { get; set; } = default!;

        [JsonProperty("next")]
        public string? Next { get; set; } = default!;
        [JsonProperty("offset")]
        public int? Offset { get; set; } = default!;
        [JsonProperty("previous")]
        public string? Previous { get; set; } = default!;
        [JsonProperty("total")]
        public int? Total { get; set; } = default!;
    }

}
