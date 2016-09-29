using System;

namespace Proxy
{
    class WindowsGraphicEngine : IHeavyGraphicEngine
    {
        public WindowsGraphicEngine()
        {
            Console.WriteLine("create windows graphic engine");
        }

        public void Draw()
        {
            Console.WriteLine("windows graphic engine draw");
        }
    }
}
