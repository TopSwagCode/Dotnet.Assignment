using Dotnet.Assignment.UnitTests.Abstractions;
using Dotnet.Assignment.UnitTests.Models;
using System;

namespace Dotnet.Assignment.UnitTests.Handlers
{
    public class PhysicalPaymentRequestHandler : Handler<PaymentRequest>, IHandler<PaymentRequest>
    {
        // Could perhaps be made abstract
        // That way all Physical payments just use this abstract base handler and don't need the same If(IsPhysicalPayment) logic.
        public PhysicalPaymentRequestHandler() 
        {
        }

        public override void Handle(PaymentRequest paymentRequest)
        {
            if (string.IsNullOrEmpty(paymentRequest.ProductName))
            {
                throw new ArgumentException("ProductName is required for Physical products.", nameof(paymentRequest.ProductName));
            }

            if(paymentRequest.ProductType == ProductType.Physical)
            {
                Console.WriteLine("Generate a packing slip for shipping for a physical product.");
            }
            

            base.Handle(paymentRequest);
        }
    }
}
