using System;

namespace FactoryPatterns.Automobiles
{
    public class BMW : IAuto
    {
        public string Name { get; private set; }

        public BMW()
        {
            
        }

        public BMW(string name)
        {
            Name = name;
        }

        public void SetName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        public void TurnOn()
        {
            Console.WriteLine($"The {Name} is on and running.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"The {Name} is turned off.");
        }
    }
}