using System;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    interface IMediator
    {
        void Notify(IComponent sender);
    }

    class Mediator : IMediator
    {
        private ComponentA componentA;
        private ComponentB componentB;

        public void Notify(IComponent sender)
        {
            if (sender == componentA)
                this.ReactOnA();
            if (sender == componentB)
                this.ReactOnB();
        }

        private void ReactOnA() { }
        private void ReactOnB() { }
    }

    interface IComponent { }

    class ComponentA : IComponent
    {
        private IMediator mediator;

        public void OperationA()
        {
            this.mediator.Notify(this);
        }
    }

    class ComponentB : IComponent
    {
        private IMediator mediator;

        public void OperationB()
        {
            this.mediator.Notify(this);
        }
    }
}
