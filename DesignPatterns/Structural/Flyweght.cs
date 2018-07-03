using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    class Context
    {
        public int uniqueState;
        public Flyweight flyweight;

        public Context(int uniqueState, int repeatingState)
        {
            this.uniqueState = uniqueState;
            this.flyweight = FlyweightFactory.GetFlyweight(repeatingState);
        }

        public void Operation() { }
    }

    class Flyweight
    {
        public int repeatingState;

        public void Operation(int uniqueState) { }
    }

    static class FlyweightFactory
    {
        private static List<Flyweight> cache = new List<Flyweight>();

        public static Flyweight GetFlyweight(int repeatingState)
        {
            foreach (var cachedFlyweight in FlyweightFactory.cache)
            {
                if (cachedFlyweight.repeatingState == repeatingState)
                    return cachedFlyweight;
            }

            Flyweight flyweight = new Flyweight
            {
                repeatingState = repeatingState
            };

            FlyweightFactory.cache.Add(flyweight);

            return flyweight;
        }
    }
}
