// Code from Uno Platform Tutorial 2 found at
// https://platform.uno/docs/articles/getting-started-tutorial-2.html#the-final-result
// Brandon Cosh
// Date: Nov 18, 2022

using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttireApp.Converters
{
    public class StringFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return string.Format(parameter.ToString(), value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
