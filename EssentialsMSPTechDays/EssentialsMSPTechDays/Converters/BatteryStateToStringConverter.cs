using System;
using System.Globalization;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsMSPTechDays.Converters
{
    public class BatteryStateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is BatteryState)
                return value.ToString();

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
