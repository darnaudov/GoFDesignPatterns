namespace AbstractFactory
{
    class TrabandFactory : ICarFactory
    {
        public ICarEngine CreateEngine()
        {
            return new TrabandEngine();
        }

        public ICarWheel CreateWheel()
        {
            return new TrabandWheel();
        }
    }
}
