namespace Memento
{
    class Originator
    {
        private string _state;

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
                System.Console.WriteLine("Originator state set at: " + State);
            }
        }

        public Originator(string state)
        {
            State = state;
        }

        public void SetMemento(Memento memento)
        {
            State = memento.State;
            System.Console.WriteLine("Originator restored at: " + State);
        }

        public Memento CreateMemento()
        {
            System.Console.WriteLine("Memento created: " + State);
            return new Memento(State);
        }
    }
}
