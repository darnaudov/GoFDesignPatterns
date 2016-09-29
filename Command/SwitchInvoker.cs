namespace Command
{
    class SwitchInvoker
    {
        private ICommand _openCommand;
        private ICommand _closeCommand;

        public SwitchInvoker(ICommand open, ICommand close)
        {
            _openCommand = open;
            _closeCommand = close;
        }

        public void Open()
        {
            _openCommand.Execute();
        }

        public void Close()
        {
            _closeCommand.Execute();
        }
    }
}
