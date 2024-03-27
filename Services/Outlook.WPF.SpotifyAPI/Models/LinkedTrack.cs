using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class LinkedTrack
    {
        public Dictionary<string, string> ExternalUrls { get; set; } = default!;
        public string Href { get; set; } = default!;
        public string Id { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string Uri { get; set; } = default!;
    }
}
