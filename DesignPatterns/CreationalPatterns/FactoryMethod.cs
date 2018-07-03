namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    interface IObject { }

    class ConcreteObjectA : IObject { }

    class ConcreteObjectB : IObject { }

    abstract class Creator
    {
        public void SomeOperation() { }

        public abstract IObject CreateObject();
    }

    class ConcreteCreatorA : Creator
    {
        // Some creator methods

        public override IObject CreateObject()
        {
            return new ConcreteObjectA();
        }
    }

    class ConcreteCreatorB : Creator
    {
        // Some creator methods

        public override IObject CreateObject()
        {
            return new ConcreteObjectB();
        }
    }
}
