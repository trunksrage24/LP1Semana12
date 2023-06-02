using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    /// <summary>
    /// class BeforeUtils that receives an enumerable of items and implements 
    /// IComparable<T>, then receives another item and returns an enumerable 
    /// containing the items in the original enumerable that, for sorting 
    /// purposes, appear before the item passed apart
    /// </summary>
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T separateItem)
            where T : IComparable<T>
        {
            foreach (T item in items)
            {
                if (item.CompareTo(separateItem) < 0)
                {
                    yield return item;
                }
            }
        }
    }
}