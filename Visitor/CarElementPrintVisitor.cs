using System;

namespace Visitor
{
    class CarElementPrintVisitor : CarElementVisitor
    {
        public void visit(Wheel wheel)
        {
            Console.WriteLine("visiting the wheel");
        }

        public void visit(Engine engine)
        {
            Console.WriteLine("visiting the engine");
        }

        public void visit(Body body)
        {
            Console.WriteLine("visiting the body");
        }

        public void visit(Car car)
        {
            Console.WriteLine("visiting the car");
        }
    }
}
