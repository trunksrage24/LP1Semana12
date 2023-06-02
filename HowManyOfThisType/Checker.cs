using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    /// <summary>
    /// class Checker, to return nr of enumerable items of a certain type
    /// </summary>
    public static class Checker
    {
        /*HowManyOfType method, which returns nr of enumerable items of a 
        certain type*/
        public static int HowManyOfType<T>(ICollection<object> items)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item is T)
                {
                    count++;
                }
            }
            return count;
        }
    }
}