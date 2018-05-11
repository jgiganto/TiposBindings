using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TiposBindings.Converters
{
    class ConvertidorGrados : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //recibo celsius 
            if (value != null)
            {
                if (value.ToString() != "")
                {
                    int gradoscelsius = 0;
                    string resultado = string.Empty;
                    //CAPTURAMOS EL VALOR ASOCIADO AL BINDING
                    gradoscelsius = int.Parse(value.ToString());
                    //REALIZAMOS LAS OPERACIONES PARA CAMBIAR A FARENHAIT
                    double gradosfarenhait = 0;
                    double ope1 = gradoscelsius * 2;
                    double ope2 = ope1 * 1 / 10;
                    double ope3 = ope1 - ope2;
                    gradosfarenhait = ope3 + 32;
                    //DEVOLVEMOS EL NUEVO VALOR CONVERTIDO
                    return gradosfarenhait;

                }
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //farenhait
            return 0;
        }
    }
}
