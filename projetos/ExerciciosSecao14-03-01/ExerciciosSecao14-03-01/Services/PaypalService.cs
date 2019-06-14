namespace ExerciciosSecao14_03_01.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double FeePercentage = 0.02;
        public double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amont)
        {
            return amont * FeePercentage;
        }
    }
}
