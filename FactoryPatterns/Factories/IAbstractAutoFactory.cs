using FactoryPatterns.Automobiles;

namespace FactoryPatterns.Factories
{
	public interface IAbstractAutoFactory
	{
		IAuto CreateSportsCar();
		IAuto CreateLuxuryCar();
		IAuto CreateEconomyCar();
	}
}
