using System;

namespace Proxy
{
    class WindowsGraphicEngineProxy : IHeavyGraphicEngine
    {
        private WindowsGraphicEngine _engine;

        public WindowsGraphicEngineProxy()
        {
            Console.WriteLine("create windows graphic engine proxy");
        }

        public void Draw()
        {
            Console.WriteLine("proxy draw");

            // Create on demand
            if (_engine == null)
            {
                _engine = new WindowsGraphicEngine();
            }

            _engine.Draw();
        }
    }
}
