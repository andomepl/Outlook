using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
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
    public class SearchDetailViewModel:BindableBase,INavigationAware
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

        private string accountGroupPngPath = Outlook.WPF.Infrastructure.UserSettingData.UserDataPath + "/account-Group.png";

        public string AccountGroupPngPath
        {
            get => accountGroupPngPath;

        }



        public ICommand ClearSearchCommand { get; }


        public SearchDetailViewModel()
        {
            ClearSearchCommand = new DelegateCommand(ClearSearch);

            songs=new List<Songs>() {
                    new Songs()
                    {
                        AlbumName="Test",
                        Image="Test",
                        ArtistName="Test"
                    },
                    new Songs()
                    {
                        AlbumName = "Test",
                        Image = "Test",
                        ArtistName = "Test"
                    },
                    new Songs()
                    {
                        AlbumName = "Test",
                        Image = "Test",
                        ArtistName = "Test"
                    },
                    new Songs()
                    {
                        AlbumName = "Test",
                        Image = "Test",
                        ArtistName = "Test"
                    }
                };
        }

        private void ClearSearch()
        {
            FullsearchText = "";
        }

        private DateTime previousTime = DateTime.Now;


        private List<Songs> songs;
        public IEnumerable<Songs> Songs { get=>songs; }






        public void DisMessage()
        {

            if ((DateTime.Now - previousTime).TotalSeconds <= 2)
            {
                return;
            }
            previousTime = DateTime.Now;

            MessageBox.Show("Hello behavior");

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
