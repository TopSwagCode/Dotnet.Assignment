using FluentAssertions;
using System;
using Xunit;

namespace Dotnet.Assignment
{
    /*
     * 
If the payment is for a membership, activate that membership.
If the payment is an upgrade to a membership, apply the upgrade.
If the payment is for a membership or upgrade, e-mail the owner and inform them of the activation/upgrade.
If the payment is for the video “Learning to Ski,” add a free “First Aid” video to the packing slip (the result of a court decision in 1997).
If the payment is for a physical product or a book, generate a commission payment to the agent.
     * 
     */

    public class PhysicalProductPaymentRequestHandlerTests
    {
        //If the payment is for a physical product, generate a packing slip for shipping.
        [Fact]
        public void PhysicalOrderRequestHandlerTest_WithProductName_ShouldNotThrowExceptions()
        {
            // Arrange
            var sut = new PhysicalPaymentRequestHandler();
            var orderRequest = new PaymentRequest
            {
                ProductName = "Something awesome"
            };

            // Act
            sut.Handle(orderRequest);

            // Assert
            sut.Invoking(x => x.Handle(orderRequest)).Should().NotThrow<ArgumentException>();
        }

        [Fact]
        public void PhysicalOrderRequestHandlerTest_WithMissingProductName_ShouldThrowArgumentException()
        {
            // Arrange
            var sut = new PhysicalPaymentRequestHandler();
            var orderRequest = new PaymentRequest();

            // Act

            // Assert
            sut.Invoking(x => x.Handle(orderRequest)).Should().Throw<ArgumentException>();
        }
    }
}
