using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    /// <summary>
    /// Guarda3<T> class: new method public void Add(T item)
    /// Adds an item if there is space
    /// Store item in the 1st variable that is different from the default value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Guarda3<T> : IEnumerable<T>
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

        public void Add(T item)
        {
            if (EqualityComparer<T>.Default.Equals(item1, default(T)))
            {
                item1 = item;
            }
            else if (EqualityComparer<T>.Default.Equals(item2, default(T)))
            {
                item2 = item;
            }
            else if (EqualityComparer<T>.Default.Equals(item3, default(T)))
            {
                item3 = item;
            }
            else
            {
                throw new InvalidOperationException("No space available to add an item.");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return item1;
            yield return item2;
            yield return item3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}