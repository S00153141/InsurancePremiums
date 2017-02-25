using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace InsurancePremiumTests
{
    [TestFixture]
    class CalculatorTest
    {
        [Test]
        public void CalculatePremiumTest()
        {
            CalculatePremium premium = new CalculatePremium();

            float prem = premium.CalculatePremium("TestGender", 1);
            Assert.AreEqual(0, prem);
        }
    }
}
