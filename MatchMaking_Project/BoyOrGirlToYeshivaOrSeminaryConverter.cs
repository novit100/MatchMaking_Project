using DP;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MatchMaking_Project
{
    public class BoyOrGirlToYeshivaOrSeminaryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var ParameterBool = parameter as bool?;
            if (ParameterBool == null)
                return DependencyProperty.UnsetValue;

            if (ParameterBool == true)
                return Enum.GetValues(typeof(YeshivaGedola));
            else
                return Enum.GetValues(typeof(Seminary));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
