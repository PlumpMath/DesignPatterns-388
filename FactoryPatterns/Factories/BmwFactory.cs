using FactoryPatterns.Automobiles;

namespace FactoryPatterns.Factories
{
    public class BmwFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new BMW("M5");
        }
    }
}