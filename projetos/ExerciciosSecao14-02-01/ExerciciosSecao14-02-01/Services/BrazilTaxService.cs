namespace ExerciciosSecao14_02_01.Services
{
    class BrazilTaxService : TaxService
    {
        public double TaxService(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
