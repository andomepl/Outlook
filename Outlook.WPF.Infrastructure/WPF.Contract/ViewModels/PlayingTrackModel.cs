using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class PlayingTrackModel:BindableBase
    {
        private string uri;

        public string Uri
        {
            get => uri;
            set
            {
                SetProperty(ref  uri, value);   
            }
        }

        private string name;

        public string Name
        {
            get => name;
            set
            {
                SetProperty(ref name, value);
            }
        }


        private string artistName;

        public string ArtistName
        {
            get => artistName;
            set
            {
                SetProperty(ref artistName, value);
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


        public ICommand PlayCommand { get; }

        public ICommand NextCommand { get; }

        

    }
}
