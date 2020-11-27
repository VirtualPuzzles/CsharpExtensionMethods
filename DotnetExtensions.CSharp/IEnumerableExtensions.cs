using System;
using System.Collections.Generic;
using System.Linq;

namespace DotnetExtensions
{
    public static partial class Extensions
    {
        public static bool AreAllEqual<TSource>(this IEnumerable<TSource> enumerable) where TSource : IEquatable<TSource>
        {
            if (enumerable.Count() == 1)
                return true;

                var temp = enumerable.FirstOrDefault();
                if (temp == null)
                    return enumerable.Skip(1).All(o => o == null);
                else
                    return enumerable.Skip(1).All(o => o?.Equals(temp) ?? false);
        }
    }
}
