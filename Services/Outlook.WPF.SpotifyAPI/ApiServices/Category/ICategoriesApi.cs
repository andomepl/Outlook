using Outlook.WPF.SpotifyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Outlook.WPF.SpotifyAPI.ApiServices.Category
{
    public interface ICategoriesApi
    {

        Task<CategoriesResponse> Get();

    }
}
