using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.Models
{
    public class CategoriesResponse
    {

        public Paging<Category, CategoriesResponse> Categories { get; set; } = default!;

    }
}
