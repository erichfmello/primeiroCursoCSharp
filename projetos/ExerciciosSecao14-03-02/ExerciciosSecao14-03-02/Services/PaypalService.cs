namespace ExerciciosSecao14_03_02.Services
{
    class PaypalService : IOnlinePayments
    {
        public const double FeePayment = 0.02;
        public const double MonthleyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthleyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePayment;
        }
    }
}
