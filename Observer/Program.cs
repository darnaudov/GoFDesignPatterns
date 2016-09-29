using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteObserver obs1 = new ConcreteObserver("obs1");
            ConcreteObserver obs2 = new ConcreteObserver("obs2");
            List<IObserver> observers = new List<IObserver>() { obs1, obs2 };
            Subject subject = new Subject();

            subject.RegisterObserver(obs1);
            subject.RegisterObserver(obs2);
            subject.State = "state 1";

            subject.UnregisterObserver(obs1);
            subject.State = "state 2";
        }
    }
}
