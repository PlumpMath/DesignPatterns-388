using System;

namespace FactoryPatterns.Automobiles
{
    public class Bmw335Xi : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("The BMW 335Xi is on and running.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The BMW 335Xi is turned off.");
        }
    }
}