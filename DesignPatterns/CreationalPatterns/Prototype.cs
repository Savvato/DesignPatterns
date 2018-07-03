namespace DesignPatterns.CreationalPatterns.Prototype
{
    interface IPrototype
    {
        IPrototype Clone();
    }

    class ConcretePrototype : IPrototype
    {
        private int fieldA;

        public ConcretePrototype(ConcretePrototype prototype)
        {
            this.fieldA = prototype.fieldA;
        }

        public IPrototype Clone()
        {
            return new ConcretePrototype(this);
        }
    }
}
