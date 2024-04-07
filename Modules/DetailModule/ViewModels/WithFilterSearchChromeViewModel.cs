using DetailModule.ViewModels.Interface;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DetailModule.ViewModels
{
    public class WithFilterSearchChromeViewModel : BindableBase, IFilterViewModeSearch, IClear
    {

        private object currentViewModel = AllSearchDetailViewModel.Get();
        public object CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }


        private string currentFilter = "All";

        public string CurrentFilter
        {
            get => currentFilter;
            set
            {
                SetProperty(ref currentFilter, value);
            }
        }


        public static WithFilterSearchChromeViewModel _instance = null;


        public static WithFilterSearchChromeViewModel Get()
        {
            if (_instance == null)
                _instance = new WithFilterSearchChromeViewModel();

            return _instance;
        }

        private string maintainerSearch;

        public void Search(string s)
        {
            maintainerSearch = s;
            Clear();
            (CurrentViewModel as IFilterViewModeSearch).Search(s);
        }


        public WithFilterSearchChromeViewModel()
        {
            ChangeViewModelWhenFilterChangedCommand = new DelegateCommand(ChangeViewModelWhenFilterChanged);
        }

        public DelegateCommand ChangeViewModelWhenFilterChangedCommand { get; }

        private void ChangeViewModelWhenFilterChanged()
        {
            switch (CurrentFilter)
            {
                case "All":
                    (CurrentViewModel as IClear).Clear();
                    CurrentViewModel = AllSearchDetailViewModel.Get();
                    (CurrentViewModel as IFilterViewModeSearch).Search(maintainerSearch);
                    break;
                case "artist":
                    (CurrentViewModel as IClear).Clear();
                    CurrentViewModel = ArtistsSearchDetailViewModel.Get();
                    (CurrentViewModel as IFilterViewModeSearch).Search(maintainerSearch);
                    break;
                case "album":
                    (CurrentViewModel as IClear).Clear();
                    CurrentViewModel = AlbumSearchDetailViewModel.Get();
                    (CurrentViewModel as IFilterViewModeSearch).Search(maintainerSearch);
                    break;
                case "playlist":
                    (CurrentViewModel as IClear).Clear();
                    CurrentViewModel = PlayListsSearchDetailViewModel.Get();
                    (CurrentViewModel as IFilterViewModeSearch).Search(maintainerSearch);
                    break;
                case "track":
                    (CurrentViewModel as IClear).Clear();
                    CurrentViewModel = SongsSearchDetailViewModel.Get();
                    (CurrentViewModel as IFilterViewModeSearch).Search(maintainerSearch);
                    break;
                default:
                    break;
            }

        }

        public void Clear()
        {
            if(CurrentViewModel is IClear ic)
            {
                ic.Clear();
            }
        }
    }
}
