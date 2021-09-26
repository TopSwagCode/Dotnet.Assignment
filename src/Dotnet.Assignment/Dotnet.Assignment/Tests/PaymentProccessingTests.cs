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
            var physicalPaymentRequestHandler = new PhysicalPaymentRequestHandler();

            physicalPaymentRequestHandler.SetNext(new BookPaymentRequestHandler());

            var orderProccessor = new OrderProcessor(physicalPaymentRequestHandler);

            var orderRequest = new PaymentRequest
            {
                Category = CategoryType.Shaver,
                ProductName = "FooBar",
                ProductType = ProductType.Physical
            };

            // Act

            // Assert
            orderProccessor.Register(orderRequest);

        }

    }

    public class OrderProcessor
    {
        private IHandler<PaymentRequest> _handler;

        public OrderProcessor(IHandler<PaymentRequest> handler)
        {
            _handler = handler;
        }

        public void Register(PaymentRequest paymentRequest)
        {
            _handler.Handle(paymentRequest);
        }
    }
}
