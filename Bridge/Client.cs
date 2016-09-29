namespace Bridge
{
    class Client
    {
        private Window _window;

        public Window Window
        {
            get
            {
                return _window;
            }

            set
            {
                _window = value;
            }
        }

        public override string ToString()
        {
            return _window.DrawRect() + " " + _window.DrawText();
        }
    }
}
