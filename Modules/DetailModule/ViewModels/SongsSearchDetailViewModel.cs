using DetailModule.Services.interfaces;
using DetailModule.Services;
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
    public class SongsSearchDetailViewModel : BindableBase, IFilterViewModeSearch, IClear
    {

        private static SongsSearchDetailViewModel _instance;

        public static SongsSearchDetailViewModel Get()
        {
            if (_instance == null)
                _instance = new SongsSearchDetailViewModel();

            return _instance;
        }

        private List<TracksModel> viewModel;

        public List<TracksModel> ViewModel
        {
            get => viewModel;
            set
            {
                SetProperty(ref viewModel, value);
            }
        }

        private readonly IGenerateSearchSongsModel s_generateSearchSongsModel = new GenerateSearchSongsModel();

        public SongsSearchDetailViewModel()
        {

        }



        public void Clear()
        {
            viewModel = null;
        }

        public async void Search(string s)
        {
            ViewModel = await s_generateSearchSongsModel.Generate(s);
        }
    }
}
