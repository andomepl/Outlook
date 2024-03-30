using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class FullSearchResponseModel:BindableBase
    {

        private TracksModel tracks;

        public TracksModel Tracks
        {
            get => tracks;
            set
            {
                SetProperty(ref tracks, value);
            }
        }

        private ObservableCollection<TracksModel> songs;

        public ObservableCollection<TracksModel> Songs 
        {
            get => songs;
            set
            {
                SetProperty(ref songs, value);
            }
        }



    }
}
