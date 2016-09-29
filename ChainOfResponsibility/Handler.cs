namespace ChainOfResponsibility
{
    abstract class Handler
    {
        protected Handler next;
        protected string handles;

        public Handler(string handles)
        {
            this.handles = handles;
        }

        protected bool CanHandle(string request)
        {
            return handles == request;
        }

        public Handler SetNext(Handler next)
        {
            this.next = next;
            return next;
        }

        public void TryToHandle(string request)
        {
            if (CanHandle(request))
            {
                Handle();
            }
            else if (next != null)
            {
                next.TryToHandle(request);
            }
        }

        public abstract void Handle();
    }
}
