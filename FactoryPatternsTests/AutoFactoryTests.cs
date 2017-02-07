using System;
using FactoryPatterns;
using FactoryPatterns.Automobiles;
using FluentAssertions;
using Xunit;

namespace FactoryPatternsTests
{
    public class AutoFactoryTests
    {
        [Theory]
        [InlineData("bmw", typeof(Bmw335Xi))]
        [InlineData("audi", typeof(AudiTTS))]
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
        public void LoadTypes_LoadsAllAvailableIAutos()
        {
            //arrange && act
            AutoFactory autoFactory = new AutoFactory();

            //assert
            autoFactory.Automobiles.Should().HaveCount(4);
        }
    }
}
