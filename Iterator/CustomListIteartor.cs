using System.Linq;

namespace Iterator
{
    class CustomListIteartor<T> : ICustomIterator<T>
    {
        private T[] _list;
        private int _curIndex;

        public CustomListIteartor(T[] list)
        {
            _list = list;
        }

        public T CurrentItem()
        {
            return _list[_curIndex];
        }

        public T First()
        {
            _curIndex = 0;
            return CurrentItem();
        }

        public T Next()
        {
            _curIndex++;
            return CurrentItem();
        }

        public bool IsDone()
        {
            return _curIndex + 1 >= _list.Length;
        }
    }
}
