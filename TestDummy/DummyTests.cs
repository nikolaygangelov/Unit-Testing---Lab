using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void LosesHealthIfAttack()
        {
            Dummy target = new Dummy(10, 10);

            target.TakeAttack(10);

            Assert.AreEqual(0, target.Health);
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttack()
        {
            Dummy target = new Dummy(0, 10);

            Assert.Throws<InvalidOperationException>(() => target.TakeAttack(2)); 
        }

        [Test]
        public void IFDeadDummyGivesExp()
        {
            Dummy target = new Dummy(0, 10);

            Assert.AreEqual(10, target.GiveExperience());
        }

        [Test]
        public void IFAliveDummyDoesNotGiveExp()
        {
            Dummy target = new Dummy(1, 10);

            Assert.Throws<InvalidOperationException>(() => target.GiveExperience());
        }
    }
}