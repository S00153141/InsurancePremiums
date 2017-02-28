using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using Premiums;

namespace PremiumsTests
{
    public class PremiumsFixture: fit.ColumnFixture
    {
        public int age;
        public string gender;

        CalculatePremiums cal = new CalculatePremiums();

        public float GetPremium()
        {
            return cal.CalculatePremium(gender, age);
        }
    }
}
