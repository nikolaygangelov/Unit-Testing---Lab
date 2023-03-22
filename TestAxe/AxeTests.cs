using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void IfLosesDurabilityAfterAttack()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy target = new Dummy(10, 10);

            //Act
            axe.Attack(target);

            //Assert
            Assert.AreEqual(9, axe.DurabilityPoints);
        }

        [Test]
        public void TestIfBrokenAxeThrowsException()
        {
            Axe axe = new Axe(10, 0);
            Dummy target = new Dummy(10, 10);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(target));
        }

    }
}