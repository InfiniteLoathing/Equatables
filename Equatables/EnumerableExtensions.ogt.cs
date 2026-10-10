using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Loathesoft.Equatables
{
    [Embedded]
    internal static class EnumerableExtensions
    {
        public static EquatableArray<T> ToEquatableArray<T>(this IEnumerable<T> enumerable) where T : IEquatable<T>
        {
            return new EquatableArray<T>(enumerable.ToArray());
        }
    }
}