using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Util.Json
{
    public static class Serialization
    {

        public static string Serialize<T>(T obj)where T:ISerializable
        {

            return JsonConvert.SerializeObject(obj);

        }

    }
}
