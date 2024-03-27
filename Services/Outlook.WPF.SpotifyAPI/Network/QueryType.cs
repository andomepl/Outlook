using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Network
{
    [Flags]
    public enum QueryType
    {
        album = 1,
        artist = 2,
        playlist = 4,
        track = 8,
        show = 16,
        episode = 32,
    }
}
