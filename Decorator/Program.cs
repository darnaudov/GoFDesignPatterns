using System;
namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee simpleCoffee = new SimpleCoffee();
            Console.WriteLine("Simple coffee:");
            Console.WriteLine("cost: " + simpleCoffee.getCost());
            Console.WriteLine("ingredients: " + simpleCoffee.getIngredients());

            ICoffee coffeeWithSugar = new CoffeeSugarDecorator(simpleCoffee);
            Console.WriteLine("Coffee with sugar:");
            Console.WriteLine("cost: " + coffeeWithSugar.getCost());
            Console.WriteLine("ingredients: " + coffeeWithSugar.getIngredients());

            ICoffee coffeeWithSugarAndMilk = new CoffeeMilkDecorator(coffeeWithSugar);
            Console.WriteLine("Coffee with sugar and milk:");
            Console.WriteLine("cost: " + coffeeWithSugarAndMilk.getCost());
            Console.WriteLine("ingredients: " + coffeeWithSugarAndMilk.getIngredients());
        }
    }
}
