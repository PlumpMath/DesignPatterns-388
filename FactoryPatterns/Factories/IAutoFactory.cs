using FactoryPatterns.Automobiles;

namespace FactoryPatterns.Factories
{
    public interface IAutoFactory
    {
        IAuto CreateAutomobile();
    }
}