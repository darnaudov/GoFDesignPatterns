namespace ChainOfResponsibility
{
    class SimpleRequestHandler : Handler
    {
        public SimpleRequestHandler() : base("simple request")
        {

        }

        public override void Handle()
        {
            System.Console.WriteLine("Simple request handled by simple handler");
        }
    }
}
