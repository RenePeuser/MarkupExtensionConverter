using System;

namespace MarkupExtensionConverter.Base
{
    public abstract class GenericMarkupExtensionConverterOneWay<T, TSourceValue> : GenericMarkupExtensionConverter<T, TSourceValue> where T : GenericMarkupExtensionConverterOneWay<T, TSourceValue>, new()
    {
        public sealed override TSourceValue ConvertBack(object value)
        {
            throw new NotImplementedException();
        }
    }
}