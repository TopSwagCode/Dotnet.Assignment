using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Dotnet.Assignment
{
    public class PaymentProccessingTests
    {
        [Fact]
        public void Test()
        {
            // Arrange
            var orderProccessor = new OrderProcessor();

            var orderRequest = new PaymentRequest
            {
                Category = CategoryType.Shaver,
                ProductName = "FooBar",
                ProductType = ProductType.Physical
            };

            var bookOrderRequestHandler = new BookPaymentRequestHandler();
            //bookOrderRequestHandler.SetNext(new PhysicalOrderRequestHandler()).SetNext()

            // Act
            orderProccessor.Register(bookOrderRequestHandler, orderRequest);

            // Assert

        }

    }

    public class OrderProcessor
    {
        public OrderProcessor()
        {
        }

        public void Register(BookPaymentRequestHandler bookOrderRequestHandler, PaymentRequest orderRequest)
        {
            bookOrderRequestHandler.Handle(orderRequest);
        }
    }
}
