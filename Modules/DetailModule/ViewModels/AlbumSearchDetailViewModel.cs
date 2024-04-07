using DetailModule.Services;
using DetailModule.Services.interfaces;
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
    public class AlbumSearchDetailViewModel : BindableBase, IFilterViewModeSearch, IClear
    {



        private static AlbumSearchDetailViewModel _instance;

        public static AlbumSearchDetailViewModel Get()
        {
            if (_instance == null)
                _instance = new AlbumSearchDetailViewModel();

            return _instance;
        }

        private List<AlbumModel> viewModel;

        public List<AlbumModel> ViewModel
        {
            get => viewModel;
            set
            {
                SetProperty(ref viewModel, value);
            }
        }

        private readonly IGenerateSearchAlbumViewModel s_generateSearchAlbumViewModel = new GenerateSearchAlbumModel();
        public AlbumSearchDetailViewModel()
        {

        }

        public void Clear()
        {
            ViewModel = null;
        }

        public async void Search(string s)
        {
            ViewModel = await s_generateSearchAlbumViewModel.Generate(s).ConfigureAwait(false);
        }
    }
}
