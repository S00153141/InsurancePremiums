using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePremium
{
    [TestFixture]
    class CalculatorTest
    {
        [Test]
        public void CalculateMale15()
        {
            Calculator calc = new Calculator();

            float prem = calc.CalculatePremium("Male", 15);

            Assert.AreEqual(0, prem);
        }

        [Test]
        public void CalculateMale31()
        {
            Calculator calc = new Calculator();

            float prem = calc.CalculatePremium("Male", 31);

            Assert.AreEqual(6, prem);
        }

        [Test]
        public void CalculateMale45()
        {
            Calculator calc = new Calculator();

            float prem = calc.CalculatePremium("Male", 45);

            Assert.AreEqual(5, prem);
        }

        [Test]
        public void CalculateMale55()
        {
            Calculator calc = new Calculator();

            float prem = calc.CalculatePremium("Male", 55);

            Assert.AreEqual(0.75, prem);
        }

        [Test]
        public void CalculateFemale15()
        {
            Calculator calc = new Calculator();

            float prem = calc.CalculatePremium("Female", 15);

            Assert.AreEqual(0, prem);
        }

        [Test]
        public void CalculateFemale25()
        {
            Calculator calc = new Calculator();

            float prem = calc.CalculatePremium("Female", 25);

            Assert.AreEqual(5, prem);
        }

        [Test]
        public void CalculateFemale40()
        {
            Calculator calc = new Calculator();

            float prem = calc.CalculatePremium("Female", 40);

            Assert.AreEqual(2.5, prem);
        }

        [Test]
        public void CalculateFemale55()
        {
            Calculator calc = new Calculator();

            float prem = calc.CalculatePremium("Female", 55);

            Assert.AreEqual(0.375, prem);
        }
    }
}
