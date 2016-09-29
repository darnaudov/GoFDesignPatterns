using System;

namespace Facade
{
    class CarFacade
    {
        private CarModel model;
        private CarEngine engine;
        private CarBody body;
        private CarAccessories accesssories;

        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accesssories = new CarAccessories();
        }

        public void CreateCar()
        {
            Console.WriteLine("Creating a car");

            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accesssories.SetAccesssories();

            Console.WriteLine("Car created");
        }
    }
}
