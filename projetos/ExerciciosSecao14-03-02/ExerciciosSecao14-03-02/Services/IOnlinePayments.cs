namespace ExerciciosSecao14_03_02.Services
{
    interface IOnlinePayments
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
