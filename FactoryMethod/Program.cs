namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IButtonCreator bombBtnCreator = new BombButtonCreator();
            IButton bombBtn = bombBtnCreator.CreateButton();

            bombBtn.Press();

            IButtonCreator warnBtnCreator = new WarnButtonCreator();
            IButton warnBtn = warnBtnCreator.CreateButton();

            warnBtn.Press();
        }
    }
}
