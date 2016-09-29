namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarBuilder standardBuilder = new StandardCarBuilder();
            Director standardDirector = new Director(standardBuilder);
            Car standardCar = standardDirector.Construct("red", "100 horse powers");
            System.Console.WriteLine(standardCar.ToString());

            ICarBuilder retroBuilder = new RetroCarBuilder();
            Director retroDirector = new Director(retroBuilder);
            Car retroCar = retroDirector.Construct("blue", "50 horse powers");
            System.Console.WriteLine(retroCar.ToString());
        }
    }
}
