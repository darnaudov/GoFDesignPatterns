namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Game chess = new Chess();
            chess.playGame(2);
        }
    }
}
