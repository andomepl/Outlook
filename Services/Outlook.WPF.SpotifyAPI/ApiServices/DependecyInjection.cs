using Microsoft.Extensions.DependencyInjection;
using Outlook.WPF.SpotifyAPI.ApiServices.Artists;
using Outlook.WPF.SpotifyAPI.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.SpotifyAPI.ApiServices
{
    public static class DependecyInjection
    {

        public static IServiceCollection AddSpotifyServices(
            this IServiceCollection services)
        {

            services.AddSingleton<ApiClient>();
            services.AddSingleton<IArtistsApi, ArtistsApi>();

            return services;
        }

    }
}
