namespace DesignPatterns.BehavioralPatterns.Visitor
{
    class Client
    {
        public void Work()
        {
            IComponent componentA = new ConcreteComponentA();
            componentA.Accept(new Visitor());
        }
    }

    interface IComponent
    {
        void Accept(IVisitor visitor);
    }

    class ConcreteComponentA : IComponent
    {
        public void SomeFeature() { }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    class ConcreteComponentB : IComponent
    {
        public void SomeFeature() { }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    interface IVisitor
    {
        void Visit(ConcreteComponentA component);
        void Visit(ConcreteComponentB component);
    }

    class Visitor : IVisitor
    {
        public void Visit(ConcreteComponentA component)
        {
        }

        public void Visit(ConcreteComponentB component)
        {
        }
    }
}
