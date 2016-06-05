using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using MarkupExtensionConverter.Extensions;

namespace MarkupExtensionConverter.Base
{
    public abstract class MarkupExtensionConverter<T> : MarkupExtensionConverterBase<T>, IValueConverter where T : MarkupExtensionConverter<T>, new()
    {
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        protected bool ValidateValue(object value)
        {
            return !value.CheckForValues(DependencyProperty.UnsetValue, null);
        }
    }
}