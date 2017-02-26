namespace Premiums
{
    public class CalculatePremiums
    {
        private float premium;

        public float CalculatePremium(string gender, int age)
        {
            if (gender.ToLower() == "female")
            {
                if (age >= 18 && age <= 30)
                {
                    premium = 5.0F;
                }
                else if (age >= 31)
                {
                    premium = 2.50F;
                }
                else
                {
                    premium = 0.00F;
                }
            }
            else
            {
                if (gender.ToLower() == "male")
                {
                    if (age >= 18 && age <= 35)
                    {
                        premium = 6.0F;
                    }
                    else if (age >= 36)
                    {
                        premium = 5.0F;
                    }
                    else
                    {
                        premium = 0.00F;
                    }
                }
                else
                {
                    premium = 0.0F;
                }
            }

            if (age >= 50)
            {
                premium *= .15F;
            }

            return premium;
        }
    }
}
