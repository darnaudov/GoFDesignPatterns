using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[3] { "1", "2", "3" };
            ICustomIterable<string> iterableList = new CustomList<string>(list);
            ICustomIterator<string> iterator = iterableList.CreateCustomIterator();

            Console.WriteLine(iterator.First());
            Console.WriteLine(iterator.IsDone());
            Console.WriteLine(iterator.Next());
            Console.WriteLine(iterator.Next());
            Console.WriteLine(iterator.IsDone());
        }
    }
}
