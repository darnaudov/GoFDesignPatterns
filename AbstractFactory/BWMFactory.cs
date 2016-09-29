namespace AbstractFactory
{
    class BWMFactory : ICarFactory
    {
        public ICarEngine CreateEngine()
        {
            return new BWMEngine();
        }

        public ICarWheel CreateWheel()
        {
            return new BWMWheel();
        }
    }
}
