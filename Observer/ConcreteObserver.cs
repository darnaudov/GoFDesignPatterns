using System;

namespace Observer
{
    class ConcreteObserver : IObserver
    {
        private string name;

        public ConcreteObserver(string name)
        {
            this.name = name;
        }

        public void Update(Subject subject)
        {
            Console.WriteLine(name + " state updated to: " + subject.State);
        }
    }
}
