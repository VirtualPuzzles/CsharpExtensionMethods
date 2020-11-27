namespace DotnetExtensions
{
    public static partial class Extensions
    {
        public static bool IsNull<TSource>(this TSource obj)
            => obj == null;
    }
}
