namespace Prototype
{
    class Client
    {
        private ICarPrototype _car;

        public Client(ICarPrototype car)
        {
            _car = car;
        }

        public override string ToString()
        {
            return _car.ToString();
        }
    }
}
