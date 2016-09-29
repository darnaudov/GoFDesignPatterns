namespace Bridge
{
    class MacWindowsImpl : IWindowImpl
    {
        public string DrawRectImpl()
        {
            return "mac draw rect";
        }

        public string DrawTextImpl()
        {
            return "mac draw text";
        }
    }
}
