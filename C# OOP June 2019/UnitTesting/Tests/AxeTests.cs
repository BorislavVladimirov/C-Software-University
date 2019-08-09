using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestFixture]
    public class AxeTests
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
        public void AxeLoosesDurabilityAfterAttack()
        {
            axe.Attack(dummy);

            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack.");

        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            axe = new Axe(10, 0);

            Assert.That(() => axe.Attack(dummy),
                Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
    }
}
