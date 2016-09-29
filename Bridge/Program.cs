namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindowImpl windowsImpl = new WindowsWindowImpl();
            Window windowsWindow = new Window(windowsImpl);

            IWindowImpl macImpl = new MacWindowsImpl();
            Window macWindow = new Window(macImpl);

            Client client = new Client();

            client.Window = windowsWindow;
            System.Console.WriteLine(client.ToString());

            client.Window = macWindow;
            System.Console.WriteLine(client.ToString());
        }
    }
}
