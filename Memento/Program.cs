using System.Collections.Generic;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client or Caretaker
            Originator originator = new Originator("initial state");
            Memento firstMemento = originator.CreateMemento();

            originator.State = "state 2";
            originator.State = "state 3";
            Memento secondMemento = originator.CreateMemento();

            originator.SetMemento(firstMemento);
        }
    }
}
