using Outlook.WPF.SpotifyAPI.Models;
using Outlook.WPF.SpotifyAPI.Network.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.ApiServices.Artists
{
    public interface IArtistsApi
    {


        Task<FullArtist> GetArtist(string id);

        //Task<ArtistsResponse> GetSeveralArtists();

    }
}
