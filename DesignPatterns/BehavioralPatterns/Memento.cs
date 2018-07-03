using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Memento
{
    class Originator
    {
        internal class Snapshot
        {
            public int paramA;
            public int paramB;
        }

        private int paramA;
        private int paramB;

        public Snapshot Save()
        {
            return new Snapshot { paramA = this.paramA, paramB = this.paramB };
        }

        public void Restore(Snapshot snapshot)
        {
            this.paramA = snapshot.paramA;
            this.paramB = snapshot.paramB;
        }
    }

    class Caretaker
    {
        private Originator originator;
        private Stack<Originator.Snapshot> history;

        public void DoSomething()
        {
            this.history.Push(this.originator.Save());

            // Some logic
        }

        public void Undo()
        {
            if (this.history.Count > 0)
                this.originator.Restore(this.history.Pop());
        }
    }
}
