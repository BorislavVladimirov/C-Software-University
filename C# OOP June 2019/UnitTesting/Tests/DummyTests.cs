using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


[TestFixture]
public class DummyTests
{
    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void CreateAxe()
    {
        int attack = 10;
        int durability = 10;

        this.axe = new Axe(attack, durability);
    }

    [SetUp]
    public void CreateDummy()
    {
        int health = 10;
        int experience = 10;

        this.dummy = new Dummy(health, experience);
    }

    [TearDown]
    public void TestCleanUp()
    {
        this.dummy = null;
        this.axe = null;
    }

    [Test]
    public void DummyLosesHealthIfAttacked()
    {
        dummy = new Dummy(20, 10);

        dummy.TakeAttack(5);

        Assert.That(dummy.Health, Is.EqualTo(15), "Dummy does not loose health when attacked.");
    }

    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        dummy = new Dummy(0, 10);

        Assert.That(() => axe.Attack(dummy),
                Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyCanGiveXP()
    {
        dummy = new Dummy(0, 10);
        int expectedExperience = 10;

        int experience = dummy.GiveExperience();
        Assert.That(experience, Is.EqualTo(expectedExperience), "Dummy doesn't give XP");
    }

    [Test]
    public void AliveDummyCantGiveXP()
    {
        dummy = new Dummy(15, 10);

        Assert.That(() => dummy.GiveExperience(),
                 Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}
