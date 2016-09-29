namespace Builder
{
    class StandardCarBuilder : ICarBuilder
    {
        private Car _car;

        public StandardCarBuilder()
        {
            _car = new Car();
        }

        public void SetColour(string colour)
        {
            _car.Colour = colour;
        }

        public void SetEngine(string engine)
        {
            _car.Engine = engine;
        }

        public Car GetResult()
        {
            return _car;
        }
    }
}
