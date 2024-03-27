using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayerModule.ViewModels
{
    public class PlayerBarViewModel : BindableBase
    {

        private string mediaPlayerSource;

        public string MediaPlayerSource
        {
            get => mediaPlayerSource;
            set
            {
                SetProperty(ref mediaPlayerSource, value);
            }
        }

        public PlayerBarViewModel()
        {

        }
    }
}
