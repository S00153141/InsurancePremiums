using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Premiums;

namespace PremiumsTests
{
    class FitnessePremiumsTest: fit.ColumnFixture
    {
        public int age { get; set; }
        public string gender { get; set; }
        private float premium { get; set; }

        CalculatePremiums premiums = new CalculatePremiums();

        public void Testing(string gen, int userAge)
        {
            premium = premiums.CalculatePremium(gender, age);
        }
    }
}
