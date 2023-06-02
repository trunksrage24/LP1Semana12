using System;
using System.Collections.Generic;

namespace MyEnumerable
{
    /// <summary>
    /// class Guarda3 which does: 
    /// Three private instance variables of type T; 
    /// Empty constructor initializes 3 vars. → default value; 
    /// Public method T GetItem(int i); 
    /// Method public void SetItem(int i , T item); 
    /// If i < 0 or i > 2 throw new IndexOutOfRangeException();
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Guarda3<T>
    {
        private T item1;
        private T item2;
        private T item3;

        public Guarda3()
        {
            item1 = default(T);
            item2 = default(T);
            item3 = default(T);
        }

        //GetItem method selects with item to choose wether i = 0, 1, 2 or 
        //something else
        public T GetItem(int i)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();

            return i switch
            {
                0 => item1,
                1 => item2,
                2 => item3,
                _ => throw new IndexOutOfRangeException(),
            };
        }

        //SetItem method, which determines the outcome wether i = 0, 1, 2 or 
        //something else
        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();

            switch (i)
            {
                case 0:
                    item1 = item;
                    break;
                case 1:
                    item2 = item;
                    break;
                case 2:
                    item3 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}