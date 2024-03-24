using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class Track
    {
        [JsonProperty("href")]
        public string Href { get; set; } = default!;



    }
}
