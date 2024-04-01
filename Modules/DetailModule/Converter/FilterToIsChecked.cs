using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace DetailModule.Converter
{
    public class FilterToIsChecked : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
          
            string matchValue=value as string;
            string contentValue = parameter as string;

            return matchValue == contentValue;


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool ischecked = (bool)value;

            if(ischecked==true) 
            {
                return parameter as string;
            }
            else
            {
                throw new Exception("Need a ischecked");
            }
            
        }
    }
}
