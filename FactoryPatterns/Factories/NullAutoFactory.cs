using FactoryPatterns.Automobiles;

namespace FactoryPatterns.Factories
{
    public class NullAutoFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new NullAuto();
        }
    }
}