using FactoryPatterns.Automobiles;

namespace FactoryPatterns.Factories
{
    public class AudiFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new Audi();
        }
    }
}