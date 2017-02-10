using FactoryPatterns.Automobiles;

namespace FactoryPatterns.Factories
{
    public class AbstractMiniCooperFactory : IAbstractAutoFactory
    {
        public IAuto CreateSportsCar()
        {
            MiniCooper mini = new MiniCooper();
            mini.AddSportsPackage();

            return mini;
        }

        public IAuto CreateLuxuryCar()
        {
            MiniCooper mini = new MiniCooper();
            mini.AddLuxuryPackage();

            return mini;
        }

        public IAuto CreateEconomyCar()
        {
            MiniCooper mini = new MiniCooper();

            return mini;
        }
    }
}