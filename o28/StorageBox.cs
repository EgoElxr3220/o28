using System;
using System.Collections.Generic;
using System.Text;

namespace o28
{
    internal class StorageBox<T>
    {
        private T Item;

        public void Store(T item)
        {
            Item = item;
        }

        public T Retrieve()
        {
            return Item; 
        }
    }
}
