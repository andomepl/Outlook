using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DetailModule.Controls
{
    public class MessageButton :Button
    {

        public static readonly DependencyProperty ImageBtnSourceProperty=
            DependencyProperty.Register("ImageBtnSource", typeof(string),typeof(MessageButton));

        public string ImageBtnSource
        {
            get => (string)GetValue(ImageBtnSourceProperty);
            set
            {
                SetValue(ImageBtnSourceProperty, value);
            }
        }


    }
}
