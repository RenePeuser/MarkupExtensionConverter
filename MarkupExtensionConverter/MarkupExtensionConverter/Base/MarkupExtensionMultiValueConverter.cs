using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Extensions;

namespace MarkupExtensionConverter.Base
{
    public abstract class MarkupExtensionMultiValueConverter<T> : MarkupExtensionConverterBase<T>, IMultiValueConverter
        where T : MarkupExtensionMultiValueConverter<T>, new()
    {
        public abstract object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);

        public abstract object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);

        protected bool ValidateValue(object[] value)
        {
            return !value.CheckForValues(DependencyProperty.UnsetValue, null);
        }
    }
}