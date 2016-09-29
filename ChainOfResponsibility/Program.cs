namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler simpleHandler = new SimpleRequestHandler();
            Handler complexHandler = new ComplexRequestHandler();

            simpleHandler.SetNext(complexHandler);
            simpleHandler.TryToHandle("complex request");
        }
    }
}
