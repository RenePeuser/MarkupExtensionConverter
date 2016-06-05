using System;
using System.Globalization;

namespace MarkupExtensionConverter.Base
{
    public abstract class MarkupExtensionMultiValueConverterOneWay<T> : MarkupExtensionConverter<T>
        where T : MarkupExtensionMultiValueConverterOneWay<T>, new()
    {
        public sealed override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}