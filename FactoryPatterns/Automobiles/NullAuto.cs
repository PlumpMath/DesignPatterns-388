namespace FactoryPatterns.Automobiles
{
    public class NullAuto : IAuto
    {
        public string Name { get; }

        public void SetName(string name)
        {            
        }

        public void TurnOn()
        {            
        }

        public void TurnOff()
        {            
        }
    }
}