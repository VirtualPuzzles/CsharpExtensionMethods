namespace DotnetExtensions
{
    public static partial class Extensions
    {
        public static bool IsNullOrWhiteSpace(this string s)
            => string.IsNullOrWhiteSpace(s);

        public static bool IsNullOrEmpty(this string s)
            => string.IsNullOrEmpty(s);
    }
}
