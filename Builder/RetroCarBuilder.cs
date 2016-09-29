namespace Builder
{
    class RetroCarBuilder : ICarBuilder
    {
        private Car _car;

        public RetroCarBuilder()
        {
            _car = new Car();
        }

        public void SetColour(string colour)
        {
            _car.Colour = "retro " + colour;
        }

        public void SetEngine(string engine)
        {
            _car.Engine = "retro " + engine;
        }

        public Car GetResult()
        {
            return _car;
        }
    }
}
