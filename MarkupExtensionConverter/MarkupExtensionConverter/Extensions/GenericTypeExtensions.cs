using System.Collections.Generic;
using System.Linq;

namespace MarkupExtensionConverter.Extensions
{
    public static class GenericTypeExtensions
    {
        public static bool CheckForValues<T>(this T source, params object[] expectedValues) where T : class
        {
            var result = expectedValues.Any(item => item == source.As<object>());
            return result;
        }
        public static bool EqualityEquals<T>(this T ob1, T ob2)
        {
            return EqualityComparer<T>.Default.Equals(ob1, ob2);
        }
    }
}
