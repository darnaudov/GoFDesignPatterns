namespace AbstractFactory
{
    interface ICarFactory
    {
        ICarEngine CreateEngine();
        ICarWheel CreateWheel();
    }
}
