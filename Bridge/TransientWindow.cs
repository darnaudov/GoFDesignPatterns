namespace Bridge
{
    class TransientWindow : Window
    {
        public TransientWindow(IWindowImpl impl) : base(impl)
        {
        }

        public string DrawCloseBox()
        {
            return DrawRect() + " and box";
        }
    }
}
