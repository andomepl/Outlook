using Newtonsoft.Json;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class AlbumModel:BindableBase
    {

        private string releaseDate;
        public string ReleaseDate
        {
            get => releaseDate;
            set
            {
                SetProperty(ref releaseDate, value);
            }
        }

        private string name;

        public string Name
        {
            get => name;
            set
            {
                SetProperty(ref name, value);
            }
        }




    }
}
