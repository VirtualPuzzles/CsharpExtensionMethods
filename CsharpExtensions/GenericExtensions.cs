namespace CsharpExtensions
{
    public static partial class Extensions
    {
        public static bool IsNull<T>(this T obj) where T : class
        => obj == null;
    }
}
