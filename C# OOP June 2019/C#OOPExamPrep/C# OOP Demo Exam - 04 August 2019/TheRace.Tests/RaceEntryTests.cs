using NUnit.Framework;
using System;
using System.Linq;

public class RaceEntryTests
{
    UnitMotorcycle unitMotorcycle = new UnitMotorcycle("Honda", 75, 450);
    UnitRider unitRider;
    RaceEntry raceEntry;

    [SetUp]
    public void Setup()
    {
        this.unitRider = new UnitRider("Pesho", unitMotorcycle);
        this.raceEntry = new RaceEntry();
    }
    [Test]
    public void TestModel()
    {
        string expected = "Honda";

        Assert.AreEqual(expected, this.unitRider.Motorcycle.Model);
    }

    [Test]
    public void TestCubicCentimeters()
    {
        int expected = 450;

        Assert.AreEqual(expected, this.unitRider.Motorcycle.CubicCentimeters);
    }

    [Test]
    public void TestCalculateAverageHorsePowerThrows()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            this.raceEntry.AddRider(this.unitRider);

            this.raceEntry.CalculateAverageHorsePower();
        });
    }

    [Test]
    public void TestAddRider()
    {
        this.raceEntry.AddRider(this.unitRider);

        int expectedCount = this.raceEntry.Counter;
        Assert.AreEqual(expectedCount, 1);
    }

    [Test]
    public void TestAddRiderThrowsExistingRider()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            this.raceEntry.AddRider(this.unitRider);

            this.raceEntry.AddRider(this.unitRider);
        });
    }

    [Test]
    public void TestNullRiderThrows()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            this.raceEntry.AddRider(null);
        });
    }

    [Test]
    public void TestCalculateAverageHorsePower()
    {
        UnitRider rider1 = new UnitRider("pesho", new UnitMotorcycle("Honda", 125, 2000));
        UnitRider rider2 = new UnitRider("gosho", new UnitMotorcycle("Suzuki", 125, 1500));

        this.raceEntry.AddRider(rider1);
        this.raceEntry.AddRider(rider2);

        var actual = this.raceEntry.CalculateAverageHorsePower();
        var expected = 125;

        Assert.AreEqual(expected,actual);
    }

}