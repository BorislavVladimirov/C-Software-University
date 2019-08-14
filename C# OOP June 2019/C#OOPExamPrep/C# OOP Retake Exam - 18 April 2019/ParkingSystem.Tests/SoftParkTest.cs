namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;

    public class SoftParkTest
    {
        private Car car;
        private SoftPark park;

        [SetUp]
        public void Setup()
        {
            this.car = new Car("BMW", "7876");
            this.park = new SoftPark();
        }

        [Test]
        public void TestCar()
        {
            string expected = "BMW";
            string reg = "7876";

            Assert.AreEqual(expected, this.car.Make);
            Assert.AreEqual(reg, this.car.RegistrationNumber);
        }

        [Test]
        public void TestParkCar()
        {
            this.park.ParkCar("A1", car);

            park.RemoveCar("A1", car);

        }

        [Test]
        public void ParkThrows()
        {
            this.park.ParkCar("A1", car);
            var secondcar = new Car("Audi", "4454");

            Assert.Throws<ArgumentException>(() => this.park.ParkCar("A44", car));
            Assert.Throws<ArgumentException>(() => this.park.ParkCar("A1", secondcar));

            Assert.Throws<InvalidOperationException>(() => this.park.ParkCar("B1", car));
        }

        [Test]
        public void RemoveThrows()
        {
            Car car234 = new Car("Asd", "342");
            Assert.Throws<ArgumentException>(() => this.park.RemoveCar("A43", car));

            Assert.Throws<ArgumentException>(() => this.park.RemoveCar("A1", car234));
        }
    }
}