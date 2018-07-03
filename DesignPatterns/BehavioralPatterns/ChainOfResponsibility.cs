namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    class Client
    {
        public void Work()
        {
            IHandler handler1 = new ConcreteHandlerA();
            IHandler handler2 = new ConcreteHandlerB();

            handler1.SetNext(handler2);
            handler1.Handle(new Request());
        }
    }

    class Request { }

    interface IHandler
    {
        void SetNext(IHandler handler);
        void Handle(Request request);
    }

    abstract class Handler : IHandler
    {
        protected IHandler next;

        public void SetNext(IHandler handler)
        {
            this.next = handler;
        }

        public abstract void Handle(Request request);
    }

    class ConcreteHandlerA : Handler
    {
        public override void Handle(Request request)
        {
            // Some handler logic

            if (this.next != null)
                this.next.Handle(request);
        }
    }

    class ConcreteHandlerB : Handler
    {
        public override void Handle(Request request)
        {
            // Some handler logic

            if (this.next != null)
                this.next.Handle(request);
        }
    }
}
