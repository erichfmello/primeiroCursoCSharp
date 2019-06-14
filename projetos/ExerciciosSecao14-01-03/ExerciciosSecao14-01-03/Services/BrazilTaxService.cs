namespace ExerciciosSecao14_01_03.Services
{
    class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if(amount <= 100)
            {
                return amount * 0.20;
            } else
            {
                return amount * 0.15;
            }
        }
    }
}
