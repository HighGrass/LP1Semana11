using System;

namespace MyGenericClass
{
    public class Guarda3<T>
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
    }
}