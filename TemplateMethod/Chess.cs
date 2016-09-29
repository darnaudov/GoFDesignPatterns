namespace TemplateMethod
{
    class Chess : Game
    {
        private int _moves;

        protected override void initializeGame()
        {
            System.Console.WriteLine("Chess game initialized");
        }

        protected override void makePlay(int player)
        {
            System.Console.WriteLine("Player " + player + " makes a move");
            _moves++;
        }

        protected override bool endOfGame()
        {
            if (_moves > 10)
            {
                System.Console.WriteLine("Checkmate!");
            }

            return _moves > 10;
        }
    }
}
