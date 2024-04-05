﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DetailModule.Converter
{
    public class SearchTextBoxConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {

            return values[0] as string;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            
            string s=value as string;

            bool isPaddingText = !string.IsNullOrEmpty(s);

            return new object[] { s, isPaddingText };

        }
    }
}
