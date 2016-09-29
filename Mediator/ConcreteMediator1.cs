namespace Mediator
{
    class ConcreteMediator1 : IMediator
    {
        public IColleague _colleauge1;
        public IColleague _colleauge2;

        public ConcreteMediator1 (IColleague colleauge1, IColleague colleauge2)
        {
            _colleauge1 = colleauge1;
            _colleauge2 = colleauge2;
        }

        public void ChangeState(string state)
        {
            _colleauge1.SetState(state);
            _colleauge2.SetState(state);
        }
    }
}
