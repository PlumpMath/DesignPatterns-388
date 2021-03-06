﻿using System;

namespace FactoryPatterns.Automobiles
{
    public class MiniCooper : IAuto
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
            Console.WriteLine($"The {Name} is on!  1.6 liters of brutal force is churning.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"The {Name} is turned off.");
        }

        public void AddSportsPackage()
        {
            Name = "Mini Cooper S";
        }

        public void AddLuxuryPackage()
        {
            Console.WriteLine("Added leather seats");
        }
    }
}