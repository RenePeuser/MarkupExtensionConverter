using System.Linq;

namespace MarkupExtensionConverter.Extensions
{
    public static class ArrayExtensions
    {
        public static bool CheckForValues<T>(this T[] source, params object[] expectedValues)
        {
            var itemsToCheck = source;
            var result = itemsToCheck.Any(item => expectedValues.Any(value => item.EqualityEquals(value)));
            return result;
        }
    }
}
