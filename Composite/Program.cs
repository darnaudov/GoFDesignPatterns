using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphic text = new Text();
            Graphic line = new Line();

            System.Console.WriteLine(text.Draw());
            System.Console.WriteLine(line.Draw());

            List<Graphic> graphics = new List < Graphic> { text, line };
            Graphic picture = new PictureComposite(graphics);

            System.Console.WriteLine(picture.Draw());
        }
    }
}
