using System;
using System.Globalization;

using Xamarin.Forms;

namespace EssentialsMSPTechDays.Converters
{
    public class PercentageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var percentage = (int)(((double)value) * 100);
                return string.Format($"{percentage} %");
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
