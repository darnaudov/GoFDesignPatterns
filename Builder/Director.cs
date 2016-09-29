namespace Builder
{
    class Director
    {
        private ICarBuilder _builder;

        public Director(ICarBuilder builder)
        {
            _builder = builder;
        }

        public Car Construct(string colour, string engine)
        {
            _builder.SetColour(colour);
            _builder.SetEngine(engine);

            return _builder.GetResult();
        }
    }
}
