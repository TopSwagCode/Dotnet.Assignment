using System;

namespace Dotnet.Assignment
{
    //If the payment is for a book, create a duplicate packing slip for the royalty department.
    public class BookPaymentRequestHandler : Handler<PaymentRequest>, IHandler<PaymentRequest>
    {

        public override void Handle(PaymentRequest orderRequest)
        {
            if(orderRequest.Category == null)
            {
                throw new ArgumentNullException(nameof(orderRequest.Category), "Noooo not null.");
            }

            Console.WriteLine("Generate a duplicate packing slip for the royalty department");

            base.Handle(orderRequest);
        }
    }
}
