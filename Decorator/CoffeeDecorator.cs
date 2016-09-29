namespace Decorator
{
    abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }
         
        public virtual int getCost()
        {
            return _coffee.getCost();
        }

        public virtual string getIngredients()
        {
            return _coffee.getIngredients();
        }
    }
}
