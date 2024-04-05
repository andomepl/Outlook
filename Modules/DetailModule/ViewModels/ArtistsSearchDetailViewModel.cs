using DetailModule.ViewModels.Interface;
using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailModule.ViewModels
{
    public class ArtistsSearchDetailViewModel : BindableBase, IFilterViewModeSearch,IClear
    {

        private static ArtistsSearchDetailViewModel _instance;

        public static ArtistsSearchDetailViewModel Get()
        {
            if (_instance == null)
                _instance = new ArtistsSearchDetailViewModel();

            return _instance;
        }

        private ArtistsSearchViewModel viewModel;

        public ArtistsSearchViewModel ViewModel
        {
            get => viewModel;
            set
            {
                SetProperty(ref viewModel, value);
            }
        }

        public ArtistsSearchDetailViewModel()
        {

        }

        public void Search(string s)
        {
            
        }

        public void Clear()
        {
            ViewModel = null;
        }
    }
}
