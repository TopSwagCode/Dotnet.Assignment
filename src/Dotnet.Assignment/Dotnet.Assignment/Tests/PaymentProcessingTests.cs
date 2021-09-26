using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Dotnet.Assignment.UnitTests.Abstractions;
using Dotnet.Assignment.UnitTests.Models;
using Dotnet.Assignment.UnitTests.Processors;

namespace Dotnet.Assignment.UnitTests.Tests
{
    public class PaymentProcessingTests
    {
        [Fact]
        public void Register_ShouldRegisterPaymentRequestAndStartProcessing_HandlerShouldBeCalledOnce()
        {
            // Arrange
            var paymentRequestHandlerMock = new Mock<IHandler<PaymentRequest>>();

            var orderProccessor = new PaymentProcessor(paymentRequestHandlerMock.Object);

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
