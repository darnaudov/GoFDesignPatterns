namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text("sample text");
            IShape shape = new TextToShapeAdapter(text);
            Editor editor = new Editor(shape);

            System.Console.WriteLine(editor.Shape.Draw());
            System.Console.WriteLine(editor.Shape.Change());
        }
    }
}
