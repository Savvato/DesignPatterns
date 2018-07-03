namespace DesignPatterns.BehavioralPatterns.Strategy
{
    class Client
    {
        public void Work()
        {
            Context context = new Context();
            ConcreteStrategyA strategy = new ConcreteStrategyA();
            context.SetStrategy(strategy);
            context.DoSomething(5);
        }
    }

    interface IStrategy
    {
        int Execute(int data);
    }

    class ConcreteStrategyA : IStrategy
    {
        public int Execute(int data)
        {
            return data + 1;
        }
    }

    class ConcreteStrategyB : IStrategy
    {
        public int Execute(int data)
        {
            return data * 2;
        }
    }

    class Context
    {
        private IStrategy strategy;

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void DoSomething(int data)
        {
            this.strategy.Execute(data);
        }
    }
}
