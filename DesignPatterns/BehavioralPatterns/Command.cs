namespace DesignPatterns.BehavioralPatterns.Command
{
    class Client
    {
        private Invoker invoker;
        private Receiver receiver;

        public Client(Invoker invoker, Receiver receiver)
        {
            this.invoker = invoker;
            this.receiver = receiver;
        }

        public void Work()
        {
            this.invoker.Command = new Command1(6, this.receiver);
            this.invoker.ExecuteCommand();
        }
    }

    interface ICommand
    {
        void Execute();
    }

    class Command1 : ICommand
    {
        // Param block
        private int param1;

        private Receiver receiver;

        public Command1(int param1, Receiver receiver)
        {
            this.param1 = param1;
            this.receiver = receiver;
        }

        public void Execute()
        {
            // Some command logic
            receiver.Operation(this.param1);
        }
    }

    class Command2 : ICommand
    {
        public void Execute()
        {
            // Some command logic
        }
    }

    class Invoker
    {
        public ICommand Command { get; set; }

        public void ExecuteCommand()
        {
            this.Command.Execute();
        }
    }

    class Receiver
    {
        public void Operation(int param)
        {
            // Some receiver logic
        }
    }
}
