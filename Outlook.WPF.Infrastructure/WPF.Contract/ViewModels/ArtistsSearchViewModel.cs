using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class ArtistsSearchViewModel:BindableBase
    {
        private ObservableCollection<ArtistsModel> _artists;

        public ObservableCollection<ArtistsModel> Artists
        {
            get => _artists;
            set
            {
                SetProperty(ref _artists, value);
            }
        }

        public ArtistsSearchViewModel(List<ArtistsModel> artistsModels)
        {
            Artists = new ObservableCollection<ArtistsModel>(artistsModels);
        }

    }
}
