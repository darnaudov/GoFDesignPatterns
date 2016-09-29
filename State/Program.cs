namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            TCPConnection connection = new TCPConnection();

            connection.State = new TCPStateListen();
            connection.Open();

            connection.State = new TCPStateEstablished();
            connection.Open();
            connection.Close();
        }
    }
}
