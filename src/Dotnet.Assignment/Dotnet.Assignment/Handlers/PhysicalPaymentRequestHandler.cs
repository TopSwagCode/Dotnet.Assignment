using Dotnet.Assignment.UnitTests.Abstractions;
using Dotnet.Assignment.UnitTests.Models;
using System;

namespace Dotnet.Assignment.UnitTests.Handlers
{
    public class PhysicalPaymentRequestHandler : Handler<PaymentRequest>, IHandler<PaymentRequest>
    {
        public PhysicalPaymentRequestHandler()
        {
        }

        public override void Handle(PaymentRequest orderRequest)
        {
            if (string.IsNullOrEmpty(orderRequest.ProductName))
            {
                throw new ArgumentException("ProductName is required for Physical products.", nameof(orderRequest.ProductName));
            }

            Console.WriteLine("Generate a packing slip for shipping for a physical product.");

            base.Handle(orderRequest);
        }
    }
}
