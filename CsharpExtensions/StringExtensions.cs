namespace CsharpExtensions
{
    public static partial class Extensions
    {
        public static bool IsNullOrWhiteSpace(this string stringToTest)
            => string.IsNullOrWhiteSpace(stringToTest);

        public static bool IsNullOrEmpty(this string stringToTest)
            => string.IsNullOrEmpty(stringToTest);
    }
}
