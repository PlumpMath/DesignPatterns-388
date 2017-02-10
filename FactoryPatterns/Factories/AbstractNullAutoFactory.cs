using FactoryPatterns.Automobiles;

namespace FactoryPatterns.Factories
{
    public class AbstractNullAutoFactory : IAbstractAutoFactory
    {
        public IAuto CreateSportsCar()
        {
            return new NullAuto();
        }

        public IAuto CreateLuxuryCar()
        {
            return new NullAuto();
        }

        public IAuto CreateEconomyCar()
        {
            return new NullAuto();
        }
    }
}