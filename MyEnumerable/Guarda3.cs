using System;
using System.Collections;
using System.Collections.Generic;

namespace MyEnumerable
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T[] items = new T[3];

        public Guarda3()
        {
            items[0] = default(T);
            items[1] = default(T);
            items[2] = default(T);
        }

        public T GetItem(int i)
        {
            ValidateIndex(i);
            return items[i];
        }

        public void SetItem(int i, T item)
        {
            ValidateIndex(i);
            items[i] = item;
        }

        private void ValidateIndex(int i)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}