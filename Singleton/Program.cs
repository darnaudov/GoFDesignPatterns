using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            World earth = World.GetInstance();
            World.GetInstance().Name = "Earth";

            Console.WriteLine(earth.Name);
            Console.WriteLine(World.GetInstance().Name);
        }
    }
}
