using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            // Arrange
            Car myCar = new CarGarage.Car();
            // Act
            myCar.Accelerate(5);
            // Assert
            Assert.Equal(5, myCar.CurrentSpeed);

        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount
            // Arrange
            Car myCar = new CarGarage.Car();
            // Act
            myCar.ReduceFuel(5);
            // Assert
            Assert.Equal(-5, myCar.CurrentFuel);
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            Car myCar = new CarGarage.Car();
            // Act
            myCar.AddFuel(5);
            // Assert
            Assert.Equal(+5, myCar.FuelingUp);
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            Car myCar = new CarGarage.Car();
            // Act
            myCar.Brake(5);
            // Assert
            Assert.Equal(-5, myCar.CurrentFuel);
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            Car myCar = new CarGarage.Car();
            // Act
            myCar.EngineOn();
            // Assert
            Assert.True(myCar.ToggleEngine);
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            Car myCar = new CarGarage.Car();
            // Act
            myCar.EngineOff();
            // Assert
            Assert.False(myCar.ToggleEngine);
        }
    }
}
