namespace Mediator
{
    class Colleague2 : IColleague
    {
        public void SetState(string state)
        {
            System.Console.WriteLine("Colleague2 state changed to: " + state);
        }
    }
}
