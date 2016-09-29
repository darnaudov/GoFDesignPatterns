namespace Decorator
{
    class CoffeeSugarDecorator : CoffeeDecorator
    {
        public CoffeeSugarDecorator(ICoffee coffee) : base(coffee)
        {
            int x = 10;
        }

        public override int getCost()
        {
            return base.getCost() + 1;
        }

        public override string getIngredients()
        {
            return base.getIngredients() + ", Sugar";
        }
    }
}
