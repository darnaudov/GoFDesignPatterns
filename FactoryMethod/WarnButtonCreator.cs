namespace FactoryMethod
{
    class WarnButtonCreator : IButtonCreator
    {
        public IButton CreateButton()
        {
            return new WarnButton();
        }
    }
}
