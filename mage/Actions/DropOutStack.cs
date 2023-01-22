using System;
using System.Collections.Generic;

namespace mage
{
    public class DropOutStack<T>
    {
        // fields
        private const int capacity = 100;
        private List<T> items;

        // constructor
        public DropOutStack()
        {
            items = new List<T>();
        }

        public T this[int i]
        {
            get { return items[i]; }
        }

        public int Count
        {
            get { return items.Count; }
        }

        public void Push(T item)
        {
            items.Add(item);
            if (items.Count > capacity)
            {
                items.RemoveAt(0);
            }
        }

        public T Pop()
        {
            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            return items[items.Count - 1];
        }

        public void Clear()
        {
            items.Clear();
        }

    }
}
