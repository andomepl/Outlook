using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class TracksModel:BindableBase
    {

        private string name;

        public string Name
        {
            get => name;
            set
            {
                SetProperty(ref name, value);
            }
        }

        private string imageUri;

        public string ImageUri
        {
            get => imageUri;
            set
            {
                SetProperty(ref imageUri, value);   
            }
        }

        private string displayType;

        public string DisplayType
        {
            get => displayType;
            set
            {
                SetProperty(ref displayType, value);
            }
        }

        private ArtistsModel artists;

        public ArtistsModel Artists
        {
            get => artists;
            set
            {
                SetProperty(ref artists, value);
            }
        }


        private string duration;
        
        public string Duration
        {
            get => duration;
            set
            {
                SetProperty(ref duration, value);
            }
        }

    }
}
