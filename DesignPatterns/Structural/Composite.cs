using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    interface IComponent
    {
        void Execute();
    }

    class Leaf : IComponent
    {
        public void Execute()
        {
            // Some logic
        }
    }

    class Composite : IComponent
    {
        private List<IComponent> children;

        public void Add(IComponent component)
        {
            this.children.Add(component);
        }

        public void Remove(IComponent component)
        {
            this.children.Remove(component);
        }

        public void Execute()
        {
            // Some logic

            foreach (var component in this.children)
            {
                component.Execute();
            }
        }
    }
}
