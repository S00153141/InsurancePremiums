using Premiums;
using NUnit.Framework;

namespace PremiumsTests
{
    [TestFixture]
    public class CalculatePremiumsTest
    {
        [Test]
        public void CalculateMale15()
        {
            CalculatePremiums calc = new CalculatePremiums();

            float prem = calc.CalculatePremium("Male", 15);

            Assert.AreEqual(0, prem);
        }

        [Test]
        public void CalculateMale31()
        {
            CalculatePremiums calc = new CalculatePremiums();

            float prem = calc.CalculatePremium("Male", 31);

            Assert.AreEqual(6, prem);
        }

        [Test]
        public void CalculateMale45()
        {
            CalculatePremiums calc = new CalculatePremiums();

            float prem = calc.CalculatePremium("Male", 45);

            Assert.AreEqual(5, prem);
        }

        [Test]
        public void CalculateMale55()
        {
            CalculatePremiums calc = new CalculatePremiums();

            float prem = calc.CalculatePremium("Male", 55);

            Assert.AreEqual(0.75, prem);
        }

        [Test]
        public void CalculateFemale15()
        {
            CalculatePremiums calc = new CalculatePremiums();

            float prem = calc.CalculatePremium("Female", 15);

            Assert.AreEqual(0, prem);
        }

        [Test]
        public void CalculateFemale25()
        {
            CalculatePremiums calc = new CalculatePremiums();

            float prem = calc.CalculatePremium("Female", 25);

            Assert.AreEqual(5, prem);
        }

        [Test]
        public void CalculateFemale40()
        {
            CalculatePremiums calc = new CalculatePremiums();

            float prem = calc.CalculatePremium("Female", 40);

            Assert.AreEqual(2.5, prem);
        }

        [Test]
        public void CalculateFemale55()
        {
            CalculatePremiums calc = new CalculatePremiums();

            float prem = calc.CalculatePremium("Female", 55);

            Assert.AreEqual(0.375, prem);
        }
    }
}