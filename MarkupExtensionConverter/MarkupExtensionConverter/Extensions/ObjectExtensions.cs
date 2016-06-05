namespace MarkupExtensionConverter.Extensions
{
    public static class ObjectExtensions
    {
        public static TResult As<TResult>(this object source) where TResult : class
        {
            return source as TResult;
        }

        public static TResult Cast<TResult>(this object source)
        {
            return (TResult)source;
        }

        public static bool IsTypeOf<T>(this object source)
        {
            return source.GetType() == typeof(T);
        }
    }
}
