using System;
using System.Globalization;

namespace MarkupExtensionConverter.Base
{
    public abstract class MarkupExtensionConverterOneWay<T> : MarkupExtensionConverter<T>
        where T : MarkupExtensionConverterOneWay<T>, new()
    {
        public sealed override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
