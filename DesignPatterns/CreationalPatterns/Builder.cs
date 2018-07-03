namespace DesignPatterns.CreationalPatterns
{
    class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ChangeBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public IThing Make(string type)
        {
            if (type == "typeA")
            {
                this.builder.BuildStep1();
            }
            else
            {
                this.builder.BuildStep2();
                this.builder.BuildStep3();
            }

            return this.builder.GetResult();
        }
    }

    interface IThing { }
    class ConcreteThingA : IThing { }

    interface IBuilder
    {
        void Reset();
        IThing GetResult();
        void BuildStep1();
        void BuildStep2();
        void BuildStep3();
    }

    class ConcreteBuilder : IBuilder
    {
        private ConcreteThingA result;

        public ConcreteBuilder()
        {
            this.result = new ConcreteThingA();
        }

        public void BuildStep1() { }
        public void BuildStep2() { }
        public void BuildStep3() { }

        public IThing GetResult()
        {
            return this.result;
        }

        public void Reset()
        {
            this.result = new ConcreteThingA();
        }
    }
}
