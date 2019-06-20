using System;
using System.Globalization;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace EssentialsMSPTechDays.Converters
{
    public class ConnectionProfileToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is List<ConnectionProfile>)
            {
                var profiles = (List<ConnectionProfile>)value;
                return String.Join(", ", profiles);
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
