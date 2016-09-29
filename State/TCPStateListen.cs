namespace State
{
    class TCPStateListen : ITCPState
    {
        public void Open()
        {
            System.Console.WriteLine("Start listening...");
        }

        public void Close()
        {
            System.Console.WriteLine("Stop listening...");
        }
    }
}
