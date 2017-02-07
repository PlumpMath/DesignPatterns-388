using System;

namespace FactoryPatterns.Automobiles
{
    public class MiniCooper : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("The Mini Cooper is on!  1.6 liters of brutal force is churning.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The Mini Cooper is turned off.");
        }
    }
}