using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;

namespace Dotnet.Assignment
{
    public class PaymentProcessingTests
    {
        [Fact]
        public void Test()
        {
            // Arrange
            var paymentRequestHandlerMock = new Mock<IHandler<PaymentRequest>>();
            
            var orderProccessor = new OrderProcessor(paymentRequestHandlerMock.Object);

            var orderRequest = new PaymentRequest
            {
                Category = CategoryType.Shaver,
                ProductName = "FooBar",
                ProductType = ProductType.Physical
            };

            // Act
            orderProccessor.Register(orderRequest);

            // Assert
            paymentRequestHandlerMock.Verify(handler => handler.Handle(orderRequest), Times.Once);

        }

    }
}
