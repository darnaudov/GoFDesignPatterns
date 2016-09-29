namespace State
{
    class TCPConnection
    {
        private ITCPState _state;

        public ITCPState State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public void Open()
        {
            _state.Open();
        }

        public void Close()
        {
            _state.Close();
        }
    }
}
