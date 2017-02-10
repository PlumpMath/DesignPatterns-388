using System;
using FactoryPatterns.Automobiles;
using FactoryPatterns.Automobiles.BMW;
using FactoryPatterns.Factories;
using FluentAssertions;
using Xunit;

namespace FactoryPatternsTests
{
	public class AutoFactoryTests
	{
		[Theory]
		[InlineData("bmw", typeof(BMW))]
		[InlineData("audi", typeof(Audi))]
		[InlineData("mini", typeof(MiniCooper))]
		[InlineData("none", typeof(NullAuto))]
		[InlineData("", typeof(NullAuto))]
		[InlineData("  ", typeof(NullAuto))]
		public void CreateInstance_GivenASpecificCarName_ReturnsTheAppropriateIAutoInstance(string carName, Type expectedCarType)
		{
			//arrange
			AutoFactory autoFactory = new AutoFactory();

			//act
			IAuto actualCar = autoFactory.CreateInstance(carName);

			//assert
			actualCar.Should().BeOfType(expectedCarType);
		}

		[Fact]
		public void CreateAutomobile_ReturnsTheConfiguredIAutoInstance()
		{
			//arrange
			IAutoFactory autoFactory = LoadFactory.GetInstance();
			Type expectedAutomobileType = typeof(MiniCooper);

			//act
			IAuto actualAutomobile = autoFactory.CreateAutomobile();

			//assert
			actualAutomobile.Should().BeOfType(expectedAutomobileType);
		}

		[Fact]
		public void LoadTypes_LoadsAllAvailableIAutos()
		{
			//arrange && act
			AutoFactory autoFactory = new AutoFactory();

			//assert
			autoFactory.Automobiles.Should().HaveCount(7);
		}
	}
}
