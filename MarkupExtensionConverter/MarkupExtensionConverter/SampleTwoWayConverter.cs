using System;
using MarkupExtensionConverter.Base;

namespace MarkupExtensionConverter
{
    public class SampleTwoWayConverter : GenericMarkupExtensionConverter<SampleTwoWayConverter, int>
    {
        public override object Convert(int value)
        {
            throw new NotImplementedException();
        }

        public override int ConvertBack(object value)
        {
            throw new NotImplementedException();
        }
    }
}