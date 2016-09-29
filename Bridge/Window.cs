namespace Bridge
{
    class Window
    {
        private IWindowImpl _impl;

        public Window(IWindowImpl impl)
        {
            _impl = impl;
        }

        public IWindowImpl Impl
        {
            get
            {
                return _impl;
            }

            set
            {
                _impl = value;
            }
        }

        public string DrawText()
        {
           return _impl.DrawTextImpl();
        }

        public string DrawRect()
        {
            return _impl.DrawRectImpl();
        }
    }
}
