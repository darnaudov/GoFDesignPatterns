using System;

namespace Command
{
    class Light : ISwitchable
    {
        public void PowerOff()
        {
            Console.WriteLine("The light is off");
        }

        public void PowerOn()
        {
            Console.WriteLine("The light is on");
        }
    }
}
