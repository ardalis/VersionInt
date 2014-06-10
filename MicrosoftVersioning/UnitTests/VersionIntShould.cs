using System;
using NUnit.Framework;

namespace MicrosoftVersioning.UnitTests
{
    [TestFixture]
    class VersionIntShould
    {
        [Test]
        public void BeCreatedAndComparableAsInt()
        {
            VersionInt version = 10;

            Assert.AreEqual(10, version);
        }

        [Test]
        [ExpectedException(ExpectedException = typeof (ArgumentOutOfRangeException))]
        public void RaiseExceptionGiven13AsStartingValue()
        {
            VersionInt version = 13;

            Assert.Fail("Should not get here without an exception.");
        }

        [Test]
        public void IncrementFrom12To14()
        {
            VersionInt version = 12;

            version++;

            Assert.AreEqual(14, version);
        }
    }
}
