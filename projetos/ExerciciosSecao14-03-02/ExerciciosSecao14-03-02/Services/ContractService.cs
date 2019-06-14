using System;
using ExerciciosSecao14_03_02.Entities;

namespace ExerciciosSecao14_03_02.Services
{
    class ContractService
    {
        private IOnlinePayments _onlinePayments;

        public ContractService(IOnlinePayments onlinePayments)
        {
            _onlinePayments = onlinePayments;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuote = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuote + _onlinePayments.Interest(basicQuote, i);
                double fullQuota = updateQuota + _onlinePayments.PaymentFee(updateQuota);

                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
