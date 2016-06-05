using System;
using System.Globalization;
using MarkupExtensionConverter.Extensions;

namespace MarkupExtensionConverter.Base
{
    public abstract class GenericMarkupExtensionConverter<T, TSourceValue> : MarkupExtensionConverter<T> where T : GenericMarkupExtensionConverter<T, TSourceValue>, new()
    {
        public sealed override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(ValidateValue(value) ? value.Cast<TSourceValue>() : default(TSourceValue));
        }

        public sealed override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ConvertBack(value);
        }

        public abstract object Convert(TSourceValue value);

        public abstract TSourceValue ConvertBack(object value);
    }
}