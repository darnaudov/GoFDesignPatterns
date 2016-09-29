namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();

            FlyweightContext charAFirstContext = new FlyweightContext(5, 5, "red");
            factory.GetFlyweight("charA").Draw(charAFirstContext);

            FlyweightContext charASndContext = new FlyweightContext(1, 3, "green");
            factory.GetFlyweight("charA").Draw(charASndContext);
        }
    }
}
