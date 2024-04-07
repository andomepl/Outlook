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
    public class ArtistsSearchDetailViewModel : BindableBase, IFilterViewModeSearch,IClear
    {

        private static ArtistsSearchDetailViewModel _instance;

        public static ArtistsSearchDetailViewModel Get()
        {
            if (_instance == null)
                _instance = new ArtistsSearchDetailViewModel();

            return _instance;
        }

        private List<ArtistsModel> viewModel;

        public List<ArtistsModel> ViewModel
        {
            get => viewModel;
            set
            {
                SetProperty(ref viewModel, value);
            }
        }

        private readonly IGenerateSearchArtistsModel s_generateSearchArtistsModel = new GenerateSearchArtistsModel();

        public ArtistsSearchDetailViewModel()
        {

        }

        public async void Search(string s)
        {
            ViewModel = await s_generateSearchArtistsModel.Generate(s);
        }

        public void Clear()
        {
            ViewModel = null;
        }
    }
}
