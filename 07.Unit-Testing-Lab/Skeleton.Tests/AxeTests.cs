using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;
        private int attack = 2;
        private int durability = 10;

        [SetUp]
        public void SetUpInitializationForAxeAndDummy()
        {
            axe = new Axe(attack, durability);
            dummy = new Dummy(1500, 10);
        }

        [Test]
        public void AssertThatAxeValuesAreSetCorrectly()
        {
            Assert.AreEqual(attack, axe.AttackPoints);
            Assert.AreEqual(durability, axe.DurabilityPoints);
        }

        [Test]
        public void WeaponLosesDurabilityAfterEachAttack()
        {
            axe.Attack(dummy);

            Assert.That(axe.DurabilityPoints, Is.EqualTo(durability - 1),
                "Axe durability points are different");
        }

        [Test]
        public void MultipleAttackLowersDurabilityCorrectly()
        {
            int initialDurability = durability;
            for (int i = 0; i < 5; i++)
            {
                axe.Attack(dummy);
            }

            Assert.AreEqual(initialDurability - 5, axe.DurabilityPoints);
        }
        
        [Test]
        public void AttackMethodThrowsExceptionWhenItReachesZero()
        {
            for (int i = 0; i < durability; i++)
            {
                axe.Attack(dummy);
            }

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}