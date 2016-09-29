using System.Collections.Generic;

namespace Composite
{
    class PictureComposite : Graphic
    {
        private List<Graphic> _graphics;

        public PictureComposite(List<Graphic> graphics)
        {
            _graphics = graphics;
        }

        public string Draw()
        {
            string result = "draw picture:";

            foreach (Graphic graphic in _graphics)
            {
                result = result + " " + graphic.Draw();
            }

            return result;
        }
    }
}
