using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailModule.ViewModels
{
    public class MusicTypeFlex:BindableBase
    {

        private string musicTypeName = String.Empty;

        public string MusicTypeName
        {
            get => musicTypeName;
            set
            {
                SetProperty(ref  musicTypeName, value);
            }
        }




    }
}
