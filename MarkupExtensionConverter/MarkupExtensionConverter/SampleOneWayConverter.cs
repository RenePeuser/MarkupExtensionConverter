using System;
using MarkupExtensionConverter.Base;

namespace MarkupExtensionConverter
{
    public class SampleOneWayConverter : GenericMarkupExtensionConverterOneWay<SampleOneWayConverter, int>
    {
        public override object Convert(int value)
        {
            throw new NotImplementedException();
        }
    }
}