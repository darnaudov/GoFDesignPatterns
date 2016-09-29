namespace TemplateMethod
{
    abstract class Game
    {
        protected int playersCount;
        protected abstract void initializeGame();
        protected abstract void makePlay(int player);
        protected abstract bool endOfGame();

        /* Template method */
        public void playGame(int playersCount)
        {
            this.playersCount = playersCount;

            initializeGame();

            int i = 0;
            while (!endOfGame())
            {
                makePlay(i);
                i = (i + 1) % playersCount;
            }
        }
    }
}
