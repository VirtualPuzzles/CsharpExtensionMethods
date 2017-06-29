using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpExtension
{
    public static partial class Extensions
    {
        public static bool AreAllEqual<T>(this List<T> list) where T : IEquatable<T>
            => list.GroupBy(o => o).Count() == 1;


    }
}
