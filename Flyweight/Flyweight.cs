using System;

namespace Flyweight
{
    class Flyweight
    {
        private string _code;
        private int reusesCount = 0;

        public Flyweight(string code)
        {
            _code = code;
        }

        public void Draw(FlyweightContext context)
        {
            Console.WriteLine(ToString() + ", " + context.ToString());
        }

        public override string ToString()
        {
            reusesCount++;
            return "code: " + _code + ", reuses: " + reusesCount;
        }
    }
}
