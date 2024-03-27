using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Network
{
    public interface ICRUD
    {

        Task<T> Get<T>(Uri uri, CancellationToken cancelToken);


    }
}
