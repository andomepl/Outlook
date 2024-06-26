﻿using DetailModule.Services.interfaces;
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
    public class PlayListsSearchDetailViewModel : BindableBase, IFilterViewModeSearch, IClear
    {

        private static PlayListsSearchDetailViewModel _instance;

        public static PlayListsSearchDetailViewModel Get()
        {
            if (_instance == null)
                _instance = new PlayListsSearchDetailViewModel();

            return _instance;
        }

        private List<PlayListsModel> viewModel;

        public List<PlayListsModel> ViewModel
        {
            get => viewModel;
            set
            {
                SetProperty(ref viewModel, value);
            }
        }

        private readonly IGenerateSearchPlayListsModel s_generateSearchPlayListsModel = new GenerateSearchPlayListsModel();
        public PlayListsSearchDetailViewModel()
        {

        }


        public void Clear()
        {
            ViewModel = null;
        }

        public async void Search(string s)
        {
            ViewModel = await s_generateSearchPlayListsModel.Generate(s);
        }
    }
}
