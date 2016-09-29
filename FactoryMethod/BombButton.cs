using System;

namespace FactoryMethod
{
    class BombButton : IButton
    {
        public void Press()
        {
            Console.WriteLine("Boom!");
        }
    }
}
