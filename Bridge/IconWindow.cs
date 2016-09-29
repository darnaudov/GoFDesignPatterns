namespace Bridge
{
    class IconWindow : Window
    {
        public IconWindow(IWindowImpl impl) : base(impl)
        {

        }

        public string DrawBorder()
        {
            return Impl.DrawRectImpl() + " " + Impl.DrawTextImpl();
        }
    }
}
