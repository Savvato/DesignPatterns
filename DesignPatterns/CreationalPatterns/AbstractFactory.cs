namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    class Client
    {
        private IAbstractFactory factory;

        public Client(IAbstractFactory factory)
        {
            this.factory = factory;
        }

        public void Work()
        {
            IThingA thingA = factory.CreateThingA();
        }
    }

    interface IThingA { }
    class ConcreteThingA1: IThingA { }
    class ConcreteThingA2: IThingA { }
    

    interface IThingB { }
    class ConcreteThingB1 : IThingB { }
    class ConcreteThingB2 : IThingB { }

    interface IAbstractFactory
    {
        IThingA CreateThingA();
        IThingB CreateThingB();
    }

    class ConcreteFactory1 : IAbstractFactory
    {
        public IThingA CreateThingA()
        {
            return new ConcreteThingA1();
        }

        public IThingB CreateThingB()
        {
            return new ConcreteThingB1();
        }
    }

    class ConcreteFactory2 : IAbstractFactory
    {
        public IThingA CreateThingA()
        {
            return new ConcreteThingA2();
        }

        public IThingB CreateThingB()
        {
            return new ConcreteThingB2();
        }
    }
}
