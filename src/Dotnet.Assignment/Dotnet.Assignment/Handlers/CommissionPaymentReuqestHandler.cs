using Dotnet.Assignment.UnitTests.Abstractions;
using Dotnet.Assignment.UnitTests.Models;
using System;

namespace Dotnet.Assignment.UnitTests.Handlers
{
    public class CommissionPaymentReuqestHandler : Handler<PaymentRequest>, IHandler<PaymentRequest>
    {
        public override void Handle(PaymentRequest paymentRequest)
        {
            if (IsCommissionPayment(paymentRequest))
            {
                Console.WriteLine("Generate a commission payment to the agent");
            }

            base.Handle(paymentRequest);
        }

        private static bool IsCommissionPayment(PaymentRequest paymentRequest)
        {
            return paymentRequest.Category == CategoryType.Book || paymentRequest.IsPhysical();
        }
    }
}
