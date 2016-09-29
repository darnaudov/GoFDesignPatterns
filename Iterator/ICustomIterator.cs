namespace Iterator
{
    interface ICustomIterator<T>
    {
        T First();
        T Next();
        T CurrentItem();
        bool IsDone();
    }
}
