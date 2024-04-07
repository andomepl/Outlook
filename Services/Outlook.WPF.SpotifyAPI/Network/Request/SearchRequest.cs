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

        private int limit;

        public int Limit
        {
            get => limit;
            set
            {
                limit = value;
            }
        }


        private int offset;

        public int Offset
        {
            get => offset;
            set
            {
                offset = value;
            }
        }


        
        public SearchRequest(string q,QueryType queryType=QueryType.album|QueryType.track|QueryType.episode|QueryType.show|QueryType.artist|QueryType.playlist, int limit=20,int offset=0)
        {

            QuerySearch = q;

            QueryType = queryType;

            Limit = limit;

            Offset=offset;

        }


    }
}
