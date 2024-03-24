using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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


    }
}
