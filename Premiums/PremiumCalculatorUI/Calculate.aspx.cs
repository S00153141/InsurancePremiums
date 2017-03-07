using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Premiums;

namespace PremiumCalculatorUI
{
    public partial class Calculate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalculatePremium(object sender, EventArgs e)
        {
            string gender = tbxGender.Value.ToString();
            int age = Convert.ToInt16(tbxAge.Value);

            CalculatePremiums prem = new CalculatePremiums();

            pOutcome.InnerText = prem.CalculatePremium(gender, age).ToString();
        }
    }
}