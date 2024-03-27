using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DetailModule.ViewModels
{
    public class DefaultSearchViewModel : BindableBase
    {

        public ObservableCollection<MusicTypeFlex> MusicFlex { get; }

        public DefaultSearchViewModel()
        {
            MusicFlex = new ObservableCollection<MusicTypeFlex>();

            MusicFlex.Add(new MusicTypeFlex() { MusicTypeName = "Music" });
            MusicFlex.Add(new MusicTypeFlex() { MusicTypeName = "Podcast" });
            MusicFlex.Add(new MusicTypeFlex() { MusicTypeName = "LiveEvent" });
            MusicFlex.Add(new MusicTypeFlex() { MusicTypeName = "Made For You" });
        }
    }
}
