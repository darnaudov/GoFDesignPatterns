namespace Decorator
{
    class SimpleCoffee : ICoffee
    {
        public int getCost()
        {
            return 1;
        }

        public string getIngredients()
        {
            return "Coffee";
        }
    }
}
