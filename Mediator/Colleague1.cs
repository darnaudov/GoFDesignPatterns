namespace Mediator
{
    class Colleague1 : IColleague
    {
        public void SetState(string state)
        {
            System.Console.WriteLine("Colleague1 state changed to: " + state);
        }
    }
}
