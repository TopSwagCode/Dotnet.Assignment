using System;

namespace Dotnet.Assignment
{
    //If the payment is for a book, create a duplicate packing slip for the royalty department.
    public class BookPaymentRequestHandler
    {

        public void Handle(PaymentRequest orderRequest)
        {
            if(orderRequest.Category == null)
            {
                throw new ArgumentNullException(nameof(orderRequest.Category), "Noooo not null.");
            }

            Console.WriteLine("Generate a duplicate packing slip for the royalty department");

            // Next()

        }
    }
}
