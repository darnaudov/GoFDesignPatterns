namespace FactoryMethod
{
    class BombButtonCreator : IButtonCreator
    {
        public IButton CreateButton()
        {
            return new BombButton();
        }
    }
}
