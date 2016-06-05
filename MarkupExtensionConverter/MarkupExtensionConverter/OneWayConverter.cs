using System;
using System.Globalization;
using MarkupExtensionConverter.Base;

namespace MarkupExtensionConverter
{
    public class OneWayConverter : MarkupExtensionConverterOneWay<OneWayConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
