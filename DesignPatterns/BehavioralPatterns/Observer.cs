using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    class Publisher
    {
        public int MainState { get; set; }

        private List<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            this.subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in this.subscribers)
            {
                subscriber.Update(this);
            }
        }

        public void OwnLogic() { }
    }

    interface ISubscriber
    {
        void Update(Publisher publisher);
    }

    class ConcreteSubscriber : ISubscriber
    {
        public void Update(Publisher publisher)
        {
            // Some logic
        }
    }
}
