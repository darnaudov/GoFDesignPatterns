using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory trabandFactory = new TrabandFactory();
            Client trabandClient = new Client(trabandFactory);

            Console.WriteLine(trabandClient.ToString());

            ICarFactory bwmFactory = new BWMFactory();
            Client bwmClient = new Client(bwmFactory);

            Console.WriteLine(bwmClient.ToString());
        }
    }
}
