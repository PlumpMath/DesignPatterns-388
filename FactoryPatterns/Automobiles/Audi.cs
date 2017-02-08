using System;

namespace FactoryPatterns.Automobiles
{
    public class Audi : IAuto
    {
        public string Name { get; private set; }

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
            Console.WriteLine();
        }

        public void TurnOff()
        {
            Console.WriteLine("The Audi TTS is turned off.");
        }
    }
}