using System;

namespace Dotnet.Assignment
{
    public class PhysicalOrderRequestHandler
    {
        public PhysicalOrderRequestHandler()
        {
        }

        public void Handle(OrderRequest orderRequest)
        {
            if (string.IsNullOrEmpty(orderRequest.ProductName))
            {
                throw new ArgumentException("ProductName is required for Physical products.", nameof(orderRequest.ProductName));
            }

            Console.WriteLine("Generate a packing slip for shipping for a physical product.");

            // Next()



        }
    }
}
