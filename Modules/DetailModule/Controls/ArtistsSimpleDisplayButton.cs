using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DetailModule.Controls
{
    public class ArtistsSimpleDisplayButton:Button
    {
        public static readonly DependencyProperty ArtistsImgProperty =
                    DependencyProperty.Register("ArtistsImg", typeof(string), typeof(ArtistsSimpleDisplayButton));

        public string ArtistsImg
        {
            get => (string)GetValue(ArtistsImgProperty);
            set
            {
                SetValue(ArtistsImgProperty, value);
            }
        }


        public static readonly DependencyProperty ArtistsNameProperty=
                DependencyProperty.Register("ArtistsName",typeof(string), typeof(ArtistsSimpleDisplayButton));

        public string ArtistsName
        {
            get => (string)GetValue(ArtistsNameProperty);
            set
            {
                SetValue(ArtistsNameProperty, value);
            }
        }

    }
}
