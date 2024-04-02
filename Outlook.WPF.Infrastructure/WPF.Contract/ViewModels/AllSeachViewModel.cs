using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class AllSeachViewModel:BindableBase
    {

        private TopResultModel topResultModel;

        public TopResultModel TopResultModel
        {
            get=>topResultModel;
            set
            {
                SetProperty(ref topResultModel, value);
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

        private ObservableCollection<ArtistsModel> artists;

        public ObservableCollection<ArtistsModel> Artists
        {
            get => artists;
            set
            {
                SetProperty(ref artists, value);
            }
        }

        private ObservableCollection<PlayListsModel> playlists;

        public ObservableCollection<PlayListsModel> PlayLists
        {
            get => playlists;
            set
            {
                SetProperty(ref playlists, value);
            }
        }

    }
}
