using Microsoft.Extensions.DependencyInjection;
using Outlook.WPF.SpotifyAPI.ApiServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceProvider serviceProvider;


        static DependencyInjection()
        {

            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddSpotifyServices();

            serviceProvider = serviceCollection.BuildServiceProvider();

        }


    }
}
