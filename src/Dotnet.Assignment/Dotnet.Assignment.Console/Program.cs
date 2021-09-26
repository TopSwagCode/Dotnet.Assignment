using Dotnet.Assignment.UnitTests.Handlers;
using Dotnet.Assignment.UnitTests.Models;
using Dotnet.Assignment.UnitTests.Processors;
using System;

namespace Dotnet.Assignment.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var physicalPaymentRequestHandler = new PhysicalPaymentRequestHandler();
            physicalPaymentRequestHandler
                .SetNext(new BookPaymentRequestHandler())
                .SetNext(new CommissionPaymentReuqestHandler());

            var paymentProcessor = new PaymentProcessor(physicalPaymentRequestHandler);

            System.Console.WriteLine("- - - - - - - -");

            System.Console.WriteLine("Book payment:");
            paymentProcessor.Register(new PaymentRequest
            {
                Category = CategoryType.Book,
                ProductName = "ASD",
                ProductType = ProductType.Physical
            });

            System.Console.WriteLine("- - - - - - - -");

            System.Console.WriteLine("DVD Movie payment:");
            paymentProcessor.Register(new PaymentRequest
            {
                Category = CategoryType.Dvd,
                ProductName = "ASD",
                ProductType = ProductType.Physical
            });

            System.Console.WriteLine("- - - - - - - -");

            System.Console.WriteLine("Online Movie payment:");
            paymentProcessor.Register(new PaymentRequest
            {
                Category = CategoryType.Dvd,
                ProductName = "ASD",
                ProductType = ProductType.Virtual
            });
        }
    }
}
