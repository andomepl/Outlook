using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class TracksModel
    {
        public string Name { get; set; } = default!;
  
        public string ImageUri { get; set; } = default!;

        public string ArtistName { get; set; } = default!;

        public string AlbumName { get; set; } = default!;

        public string Duration { get; set; } = default!;

    }
}
