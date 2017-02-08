using System.Reflection;

namespace FactoryPatterns.Factories
{
    public static class LoadFactory
    {
        public static IAutoFactory GetInstance()
        {
            string factoryToUse = Properties.Factories.Default.AutoFactory;
            if (!string.IsNullOrWhiteSpace(factoryToUse))
            {
                return Assembly.GetExecutingAssembly().CreateInstance(factoryToUse) as IAutoFactory;
            }

            return new NullAutoFactory();
        }
    }
}