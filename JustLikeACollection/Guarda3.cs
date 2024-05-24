using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private readonly T[] items = new T[3];

        public Guarda3()
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = default(T);
            }
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

        public void Add(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], default(T)))
                {
                    items[i] = item;
                    return;
                }
            }

            throw new InvalidOperationException("The Guarda3<T> instance is already full.");
        }

        private void ValidateIndex(int i)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException("Index must be between 0 and 2.");
            }
        }
    }
}