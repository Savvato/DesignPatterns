using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    public static class Program
    {
        private static readonly string[] DesignPatterns =
        {
            // === Creational ===
            "Abstract Factory",
            "Builder",
            "Factory Method",
            "Prototype",
            "Singleton",

            // === Structural ===
            "Adapter",
            "Bridge",
            "Composite",
            "Decorator",
            "Facade",
            "Flyweight",
            "Proxy",

            // === Behavioral ===
            "Chain of responsibility",
            "Command",
            "Interpreter",
            "Iterator",
            "Mediator",
            "Memento",
            "Observer",
            "State",
            "Strategy",
            "Template method",
            "Visitor"
        };

        private static readonly int PatternQuestionsCount = (DesignPatterns.Length > 4) ? 4 : DesignPatterns.Length;

        public static void Main(string[] args)
        {
            List<string> patterns = Program.DesignPatterns.ToList<string>();
            Random random = new Random();
            for(int i = 1; i <= Program.PatternQuestionsCount; i++)
            {
                string pattern = patterns.ElementAt(random.Next(0, patterns.Count - 1));
                patterns.Remove(pattern);
                Console.WriteLine(pattern);
            }
            Console.ReadLine();
        }
    }
}
