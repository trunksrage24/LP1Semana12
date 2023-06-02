using System;
using System.Collections.Generic;

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