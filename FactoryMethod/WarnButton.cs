using System;

namespace FactoryMethod
{
    class WarnButton : IButton
    {
        public void Press()
        {
            Console.WriteLine("Warning!");
        }
    }
}
