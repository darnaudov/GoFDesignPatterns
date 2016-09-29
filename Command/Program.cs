namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ISwitchable lamp = new Light();

            ICommand openSwitchCommand = new OpenSwitchCommand(lamp);
            ICommand closeSwitchCommand = new CloseSwitchCommand(lamp);

            SwitchInvoker switchInvoker = new SwitchInvoker(openSwitchCommand, closeSwitchCommand);

            switchInvoker.Open();
            switchInvoker.Close();
        }
    }
}
