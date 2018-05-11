using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TiposBindings.Converters
{
    class ConvertidorMoneda : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //recibo euros
            if (value != null)
            {
                if (value.ToString() != "")
                {
                    int euro = 0;
                    String resultado = String.Empty;
                    euro = int.Parse(value.ToString());
                    double dolar = euro * 1.19;
                    return dolar;
                }
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //dolares
            return 0;
        }
    }
}
