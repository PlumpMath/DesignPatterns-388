using FactoryPatterns.Automobiles;
using FactoryPatterns.Automobiles.BMW;

namespace FactoryPatterns.Factories
{
    public class AbstractBmwFactory : IAbstractAutoFactory
    {
        public IAuto CreateSportsCar()
        {
            return new BmwM3();
        }

        public IAuto CreateLuxuryCar()
        {
            return new Bmw740i();
        }

        public IAuto CreateEconomyCar()
        {
            return new Bmw328i();
        }
    }
}