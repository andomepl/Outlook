using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DetailModule.ViewModels
{
    public class SearchDetailViewModel:BindableBase
    {

        private string fullSearchText = String.Empty;


        public string FullsearchText
        {
            get { return fullSearchText; }
            set
            {
                SetProperty(ref fullSearchText, value);
            }
        }


        private string profilePngPath = Outlook.WPF.Infrastructure.UserSettingData.UserDataPath+"/profile.png";

        public string ProfilPngPath
        {
            get => profilePngPath;

        }

        public ICommand ClearSearchCommand { get; }


        public SearchDetailViewModel()
        {
            ClearSearchCommand = new DelegateCommand(ClearSearch);
        }

        private void ClearSearch()
        {
            FullsearchText = "";
        }

        private DateTime previousTime = DateTime.Now;

        public void DisMessage()
        {

            if ((DateTime.Now - previousTime).TotalSeconds <= 2)
            {
                return;
            }
            previousTime = DateTime.Now;

            MessageBox.Show("Hello behavior");

        }


    }
}
