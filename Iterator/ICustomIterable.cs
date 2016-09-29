namespace Iterator
{
    interface ICustomIterable<T>
    {
        ICustomIterator<T> CreateCustomIterator();
    }
}
