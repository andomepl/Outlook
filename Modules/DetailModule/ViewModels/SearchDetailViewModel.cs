using Microsoft.Extensions.DependencyInjection;
using Outlook.WPF.Infrastructure;
using Outlook.WPF.Infrastructure.WPF.Contract.ViewModels;
using Outlook.WPF.SpotifyAPI.ApiServices.Artists;
using Outlook.WPF.SpotifyAPI.Models;
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
using System.Windows.Threading;

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
            set
            {
                SetProperty(ref profilePngPath,value);
            }

        }

        private string accountGroupPngPath = Outlook.WPF.Infrastructure.UserSettingData.UserDataPath + "/account-Group.png";

        public string AccountGroupPngPath
        {
            get => accountGroupPngPath;

        }



        public ICommand ClearSearchCommand { get; }


        public SearchDetailViewModel()
        {



            //Task.Run(
            //    async () =>
            //    {
            //        var s = DependencyInjection.serviceProvider.GetService<IArtistsApi>();

            //        // 孙燕姿 =0SIXZXJCAhNU8sxK0qm7hn

            //        var fullart =await s.GetArtist("0SIXZXJCAhNU8sxK0qm7hn");

            //        Dispatcher.CurrentDispatcher.Invoke(() =>
            //        {
            //            ProfilPngPath = fullart.Images[1].Url;
            //        });
                    
            //    }
            //);


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
