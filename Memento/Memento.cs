namespace Memento
{
    class Memento
    {
        private readonly string _state;

        public string State
        {
            get;
            set;
        }

        public Memento(string state)
        {
            State = state;
        }
    }
}
