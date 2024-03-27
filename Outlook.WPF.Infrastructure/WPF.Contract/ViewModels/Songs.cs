using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class Songs:BindableBase
    {

        private string image = string.Empty;

        public string Image
        {
            get => image;
            set
            {
                SetProperty(ref image, value);
            }
        }

        private string artistName = string.Empty;

        public string ArtistName
        {
            get => artistName;
            set
            {
                SetProperty(ref artistName, value);
            }
        }

        private string albumName = string.Empty;

        public string AlbumName
        {
            get => albumName;
            set
            {
                SetProperty(ref albumName, value);
            }
        }

        private string songDuration= DateTime.Now.ToString("mm:ss");

        public string SongDuration
        {
            get => songDuration;
            set
            {
                SetProperty(ref  songDuration, value);  
            }
        }

    }
}
