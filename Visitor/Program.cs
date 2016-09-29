namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel wheel = new Wheel();
            Body body = new Body();
            Engine engine = new Engine();
            CarElement[] elements = new CarElement[3] { wheel, body, engine };
            Car car = new Car(elements);
            CarElementPrintVisitor visitor = new CarElementPrintVisitor();

            car.accept(visitor);
        }
    }
}
