using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Util.Json
{
    public static class Deserialzation
    {

        public static T? Deserialize<T>(string jsonString) where T : ISerializable
        {

            return JsonConvert.DeserializeObject<T>(jsonString);

        }
    }
}
