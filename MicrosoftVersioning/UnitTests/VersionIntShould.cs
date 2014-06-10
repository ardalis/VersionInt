using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
