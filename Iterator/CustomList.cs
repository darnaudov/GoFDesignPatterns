using System.Collections.Generic;

namespace Iterator
{
    class CustomList<T> : ICustomIterable<T>
    {
        private T[] _list;

        public CustomList(T[] list)
        {
            _list = list;
        }

        public ICustomIterator<T> CreateCustomIterator()
        {
            return new CustomListIteartor<T>(_list);
        }
    }
}
