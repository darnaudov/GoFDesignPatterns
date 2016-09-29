namespace State
{
    class TCPStateEstablished : ITCPState
    {
        public void Open()
        {
            System.Console.WriteLine("Start establishing...");
        }

        public void Close()
        {
            System.Console.WriteLine("Stop establishing...");
        }
    }
}
