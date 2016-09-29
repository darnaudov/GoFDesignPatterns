namespace ChainOfResponsibility
{
    class ComplexRequestHandler : Handler
    {
        public ComplexRequestHandler() : base("complex request")
        {
        }

        public override void Handle()
        {
            System.Console.WriteLine("Complex request handled by complex handler");
        }
    }
}
