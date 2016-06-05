using System;
using System.Windows.Markup;

namespace MarkupExtensionConverter.Base
{
    public abstract class MarkupExtensionConverterBase<T> : MarkupExtension where T : new()
    {
        private static readonly T Instance = new T();

        public sealed override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Instance;
        }
    }
}
