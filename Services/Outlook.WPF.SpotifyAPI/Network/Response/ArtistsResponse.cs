using Outlook.WPF.SpotifyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Network.Response
{
    public class ArtistsResponse
    {

        public List<FullArtist> Artists { get; set; } = default!;

    }
}
