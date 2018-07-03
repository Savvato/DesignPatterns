namespace DesignPatterns.Structural
{
    class Client
    {

    }

    interface IComponent
    {
        void Execute();
    }

    class ConcreteComponent : IComponent
    {
        public void Execute()
        {
            // Some component logic
        }
    }

    abstract class BaseDecorator : IComponent
    {
        protected IComponent component;

        public BaseDecorator(IComponent component)
        {
            this.component = component;
        }

        public abstract void Execute();
    }

    class ConcreteDecorator : BaseDecorator
    {
        public ConcreteDecorator(IComponent component) : base(component)
        {
        }

        public override void Execute()
        {
            // Some decorator logic
            this.component.Execute();
        }
    }
}
