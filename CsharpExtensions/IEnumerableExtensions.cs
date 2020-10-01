using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpExtensions
{
    public static partial class Extensions
    {
        public static bool AreAllEqual<TSource>(this IEnumerable<TSource> enumerable) where TSource : IEquatable<TSource>
        {
            if (enumerable.Count() == 1)
                return true;

            bool isFirstSet = false;
            TSource firstItem = default;
            bool isFirstItemNull = false;

            using (var iter = enumerable.GetEnumerator())
            {
                while (iter.MoveNext())
                {
                    if (!isFirstSet)
                    {
                        var temp = iter.Current;

                        if (!iter.MoveNext()) 
                            return true;

                        firstItem = temp;
                        isFirstSet = true;
                        isFirstItemNull = firstItem == null;
                    }


                    if (iter.Current == null && !isFirstItemNull)
                        return false;

                    if (iter.Current != null && !iter.Current.Equals(firstItem))
                        return false;
                }
            }

            return true;
        }
    }
}
