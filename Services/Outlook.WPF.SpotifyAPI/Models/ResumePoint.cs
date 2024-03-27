using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class ResumePoint
    {
        [JsonProperty("fully_played")]
        public bool FullyPlayed { get; set; }

        [JsonProperty("resume_position_ms")]
        public int ResumePositionMs { get; set; }
    }
}
