namespace AbstractFactory
{
    class Client
    {
        private ICarFactory _factory;
        private ICarEngine _engine;
        private ICarWheel _wheel;

        public Client(ICarFactory factory)
        {
            _factory = factory;
            _engine = _factory.CreateEngine();
            _wheel = _factory.CreateWheel();
        }

        public override string ToString()
        {
            return _engine.Start() + "\n" + _wheel.Turn();
        }
    }
}
