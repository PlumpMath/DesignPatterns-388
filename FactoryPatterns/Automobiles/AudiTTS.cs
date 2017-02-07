using System;

namespace FactoryPatterns.Automobiles
{
    public class AudiTTS : IAuto
    {
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