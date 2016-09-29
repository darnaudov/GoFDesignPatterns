namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarPrototype bwm = new BwmPrototype();
            Client bwmClient = new Client(bwm);
            System.Console.WriteLine(bwmClient.ToString());

            ICarPrototype fait = new FaitPrototype();
            Client faitClient = new Client(fait);
            System.Console.WriteLine(faitClient.ToString());
        }
    }
}
