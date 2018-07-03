namespace DesignPatterns.BehavioralPatterns.State
{
    interface IState
    {
        void StateMethodA();
        void StateMethodB();
    }

    class ConcreteStateA : IState
    {
        public void StateMethodA()
        {
            // Some state behavior
        }

        public void StateMethodB()
        {
            // Some state behavior
        }
    }

    class ConcreteStateB : IState
    {
        public void StateMethodA()
        {
            // Some state behavior
        }

        public void StateMethodB()
        {
            // Some state behavior
        }
    }

    class Context
    {
        private IState currentState;

        public Context(IState initialState)
        {
            this.currentState = initialState;
        }

        public void ChangeState(IState state)
        {
            this.currentState = state;
        }

        public void MethodA()
        {
            this.currentState.StateMethodA();
        }

        public void MethodB()
        {
            this.currentState.StateMethodB();
        }
    }
}
