using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Iterator
{
    interface IIterator<T>
    {
        T Current { get; }
        T GetNext();
        bool HasMore();
    }

    interface IIterableCollection<T>
    {
        IIterator<T> CreateIterator();
    }

    class ConcreteIterator<T> : IIterator<T>
    {
        private ConcreteCollection<T> collection;
        private int index = 0;

        public ConcreteIterator(ConcreteCollection<T> collection)
        {
            this.collection = collection;
        }

        public T Current => this.collection[this.index];

        public T GetNext()
        {
            this.index++;
            return this.Current;
        }

        public bool HasMore()
        {
            return this.index < this.collection.Count;
        }
    }

    class ConcreteCollection<T> : List<T>, IIterableCollection<T>
    {
        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }
    }
}
