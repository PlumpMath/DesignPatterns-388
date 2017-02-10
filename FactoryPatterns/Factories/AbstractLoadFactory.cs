using System.Reflection;

namespace FactoryPatterns.Factories
{
    public class AbstractLoadFactory
    {
        public static IAbstractAutoFactory GetInstance()
        {
            string factoryToUse = Properties.Factories.Default.AutoFactory;
            if (!string.IsNullOrWhiteSpace(factoryToUse))
            {
                return Assembly.GetExecutingAssembly().CreateInstance(factoryToUse) as IAbstractAutoFactory;
            }

            return new AbstractNullAutoFactory();
        }
    }
}