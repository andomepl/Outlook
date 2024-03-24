using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeModule.ViewModels
{
    public class homeViewModel:BindableBase
    {

        private bool isHomeBtnChecked=false;

        public bool IsHomeBtnChecked
        {
            get => isHomeBtnChecked;
            set
            {
                if (IsSearchBtnChecked == true)
                    IsSearchBtnChecked = false;
                SetProperty(ref isHomeBtnChecked, value);
            }
        }

        private bool isSearchBtnChecked = false;

        public bool IsSearchBtnChecked
        {
            get => isSearchBtnChecked;
            set
            {
                if(IsHomeBtnChecked==true)
                    IsHomeBtnChecked = false;

                SetProperty(ref isSearchBtnChecked, value);
            }
        }

    }
}
