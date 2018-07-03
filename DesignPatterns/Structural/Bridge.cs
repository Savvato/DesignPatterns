namespace DesignPatterns.Structural.Bridge
{
    interface IImplementation
    {
        void MethodA();
        void MethodB();
        void MethodC();
    }

    class ConcreteImplementationA : IImplementation
    {
        public void MethodA() { }
        public void MethodB() { }
        public void MethodC() { }
    }

    class ConcreteImplementationB : IImplementation
    {
        public void MethodA() { }
        public void MethodB() { }
        public void MethodC() { }
    }

    class Abstraction
    {
        public IImplementation Implementation { get; set; }

        public void FeatureA() { }
        public void FeatureB() { }
        public void FeatureC() { }
    }
}
