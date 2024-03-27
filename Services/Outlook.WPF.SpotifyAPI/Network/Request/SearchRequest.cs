using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Network.Request
{



    public class SearchRequest
    {

        private QueryType queryType;

        public QueryType QueryType
        {
            get => queryType;
            set
            {
                queryType = value;
            }
        }

        private string querySearch;
        public string QuerySearch
        {
            get=>querySearch;
            set
            {
                querySearch = value;
            }
        }
        
        public SearchRequest(string q,QueryType queryType=QueryType.album|QueryType.track|QueryType.episode|QueryType.show|QueryType.artist|QueryType.playlist)
        {

            QuerySearch = q;

            QueryType = queryType;

        }


    }
}
