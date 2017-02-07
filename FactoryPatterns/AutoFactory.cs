using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FactoryPatterns.Automobiles;

namespace FactoryPatterns
{
    public class AutoFactory
    {
        public Dictionary<string, Type> Automobiles;

        public AutoFactory()
        {
            LoadTypes();
        }

        public IAuto CreateInstance(string carName)
        {
            if (string.IsNullOrWhiteSpace(carName))
            {
                return new NullAuto();
            }

            Type carType = GetTypeToCreate(carName);

            if (carType == null)
            {
                return new NullAuto();
            }

            return Activator.CreateInstance(carType) as IAuto;
        }

        private Type GetTypeToCreate(string carName)
        {
            return Automobiles.FirstOrDefault(a => a.Key.Contains(carName)).Value;          
        }

        private void LoadTypes()
        {
            Automobiles = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(IAuto).IsAssignableFrom(t) && !t.IsInterface)
                .ToDictionary(t => t.Name.ToLower(), t => t);
        }
    }
}
