namespace Builder
{
    interface ICarBuilder
    {
        void SetEngine(string engine);
        void SetColour(string colour);
        Car GetResult();
    }
}
