using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DetailModule.Controls
{
    public class PlaceholderTextBox:TextBox
    {

        public static readonly DependencyProperty PlaceholderDependencyProperty =
                                                            DependencyProperty.Register(
                                                                "Placeholder",
                                                                typeof(string),
                                                                typeof(PlaceholderTextBox),
                                                                new FrameworkPropertyMetadata(
                                                                    "what you want to play?",
                                                                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                                                                    new PropertyChangedCallback(PlaceHolderTextBoxChangedCallback)
                                                                ));

        public static void PlaceHolderTextBoxChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PlaceholderTextBox placeholderTextBox = d as PlaceholderTextBox;

            if(string.IsNullOrEmpty(placeholderTextBox.Text))
            {
            }

            if(e.NewValue==null)
            {
                placeholderTextBox.Placeholder = "what you want to play?";
            }


            placeholderTextBox.Placeholder=e.NewValue as string;
        }


        public string Placeholder
        {
            get
            {
                return GetValue(PlaceholderDependencyProperty) as string;
            }
            set
            {
                SetValue(PlaceholderDependencyProperty, value);
            }
        }


    }
}
