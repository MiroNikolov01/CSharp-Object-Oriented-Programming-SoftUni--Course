using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;
        private int health = 150;
        private int experience = 20;

        [SetUp]
        public void InitializeDummy()
        {
            dummy = new Dummy(health, experience);
        }

        [Test]
        public void CheckIfHealthValueIsSetCorrectly()
        {
            Assert.That(dummy.Health, Is.EqualTo(health));
        }

        [Test]
        public void ExperienceThrowsExepctionWhenNotDead()
        {
            dummy = new Dummy(150, 20);
            Assert.Throws<InvalidOperationException>
            (
                () => dummy.GiveExperience()
            );
        }

        [Test]
        public void WhenDummyDiesThrowsException()
        {
            Dummy deadDummy = new Dummy(0, 10);
            Assert.Throws<InvalidOperationException>
            (
                () => deadDummy.TakeAttack(2000)
            );
        }

        [Test]
        public void ReturnExperienceIfDummyIsDead()
        {
            dummy.TakeAttack(health);
            Assert.That(dummy.IsDead, Is.True,"Dummy should be dead before giving experience.");
            Assert.That(dummy.GiveExperience(), Is.EqualTo(experience));
        }

        [Test]
        public void ReturnTrueIfDummyIsDead()
        {
            dummy.TakeAttack(health);
            Assert.That(dummy.IsDead, Is.True);
        }

        [TearDown]
        public void CleanUpDummy()
        {
            dummy = null;
        }
        
        
    }
}