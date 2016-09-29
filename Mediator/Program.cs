namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IColleague colleague1 = new Colleague1();
            IColleague colleague2 = new Colleague2();
            IMediator mediator = new ConcreteMediator1(colleague1, colleague2);
            mediator.ChangeState("new input");
        }
    }
}
