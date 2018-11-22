using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace feldinlabel_cshp15c
{
    class TotalZahl : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            decimal ersteZahl = 0;
            decimal zweiteZahl = 0;
            decimal result = 0;
            ersteZahl = (values[0] != null && values[0] != DependencyProperty.UnsetValue) ? System.Convert.ToDecimal(values[0]) : 0;
            zweiteZahl = (values[0] != null && values[1] != DependencyProperty.UnsetValue) ? System.Convert.ToDecimal(values[1]) : 0;
            result = (ersteZahl + zweiteZahl);
            return result.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
