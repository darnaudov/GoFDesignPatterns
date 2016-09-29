namespace Decorator
{
    class CoffeeMilkDecorator : CoffeeDecorator
    {
        public CoffeeMilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override int getCost()
        {
            return base.getCost() + 1;
        }

        public override string getIngredients()
        {
            return base.getIngredients() + ", Milk";
        }
    }
}
