using Dotnet.Assignment.UnitTests.Abstractions;
using Dotnet.Assignment.UnitTests.Models;
using System;

namespace Dotnet.Assignment.UnitTests.Handlers
{
    //If the payment is for a book, create a duplicate packing slip for the royalty department.
    public class BookPaymentRequestHandler : Handler<PaymentRequest>, IHandler<PaymentRequest>
    {

        public override void Handle(PaymentRequest paymentRequest)
        {
            if (paymentRequest.Category == null)
            {
                throw new ArgumentNullException(nameof(paymentRequest.Category), "Noooo not null.");
            }

            Console.WriteLine("Generate a duplicate packing slip for the royalty department");

            base.Handle(paymentRequest);
        }
    }
}
