namespace BlueOrigin.Tests
{
    using System;
    using NUnit.Framework;

    public class SpaceshipTests
    {
        private Astronaut astronaut;
        private Spaceship spaceship;

        [SetUp]
        public void Setup()
        {
            astronaut = new Astronaut("Pesho", 10);
            spaceship = new Spaceship("Station", 20);
        }

        [Test]
        public void TestRemove()
        {
            bool expectedResult = true;

            this.spaceship.Add(astronaut);
            var name = "Pesho";

            var result = this.spaceship.Remove(name);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestAddThrows()
        {
            spaceship.Add(astronaut);

            Astronaut secondAst = new Astronaut("Pesho", 20);

            Assert.Throws<InvalidOperationException>(() => this.spaceship.Add(secondAst));
        }
        [Test]
        public void TestCapacity()
        {
            Spaceship spaceship1 = new Spaceship("Test", 5);
            int expected = 5;

            Assert.AreEqual(expected, spaceship1.Capacity);
        }

        [Test]
        public void TestCount()
        {
            spaceship.Add(astronaut);

            int expected = 1;

            Assert.AreEqual(expected, this.spaceship.Count);
        }

        [Test]
        public void TestOxygen()
        {
            int expected = 10;

            Assert.AreEqual(expected, this.astronaut.OxygenInPercentage);
        }

        [Test]
        public void TestName()
        {
            var expected = "Station";

            Assert.AreEqual(expected, this.spaceship.Name);
        }

        [Test]
        public void CapacityThrows()
        {
            spaceship = new Spaceship("Test", 1);
            spaceship.Add(astronaut);

            Astronaut astronaut1 = new Astronaut("S", 12);

            Assert.Throws<InvalidOperationException>(() => this.spaceship.Add(astronaut1));
        }

        [Test]
        public void ThrowsCapacity()
        {
            Assert.Throws<ArgumentException>(() => this.spaceship = new Spaceship("Asd", -1));
        }


        [Test]
        public void NameThrows()
        {
            Assert.Throws<ArgumentNullException>(() => this.spaceship = new Spaceship("", 2));
        }
    }
}