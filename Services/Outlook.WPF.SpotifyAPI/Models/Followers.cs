using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class Followers
    {
        [JsonProperty("href")]
        public string Href { get; set; } = default!;

        [JsonProperty("total")]
        
        public int Total { get; set; }


    }
}
