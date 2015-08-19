using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TMC.Shared
{
    /// <summary>
    /// Provides extension utility methods for IEnumerable<T>
    /// Author : Nagarro 
    /// </summary>
    public static class GenericIEnumberableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (T item in collection)
            {
                action(item);
            }
        }

        public static IEnumerable<T> Clone<T>(this IEnumerable<T> collection) where T : ICloneable
        {
            return collection.Select(item => (T)item.Clone());
        }
    }
}