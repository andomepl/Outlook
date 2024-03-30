using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlook.WPF.Infrastructure.WPF.Contract.ViewModels
{
    public class ArtistsModel:BindableBase
    {

        private string imageUri;

        public string ImageUri
        {
            get => imageUri;
            set
            {
                SetProperty(ref imageUri, value);
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
