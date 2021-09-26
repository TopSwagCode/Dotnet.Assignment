using Dotnet.Assignment.UnitTests.Handlers;
using Dotnet.Assignment.UnitTests.Models;
using FluentAssertions;
using System;
using Xunit;

namespace Dotnet.Assignment.UnitTests.Tests
{
    /*
     * 
        If the payment is for a membership, activate that membership.
        If the payment is an upgrade to a membership, apply the upgrade.
        If the payment is for a membership or upgrade, e-mail the owner and inform them of the activation/upgrade.
        If the payment is for the video “Learning to Ski,” add a free “First Aid” video to the packing slip (the result of a court decision in 1997).
     * 
     */

    public class PhysicalProductPaymentRequestHandlerTests
    {
        //If the payment is for a physical product, generate a packing slip for shipping.
        [Fact]
        public void PhysicalpaymentRequestHandlerTest_WithProductName_ShouldNotThrowExceptions()
        {
            // Arrange
            var sut = new PhysicalPaymentRequestHandler();
            var paymentRequest = new PaymentRequest
            {
                ProductName = "Something awesome"
            };

            // Act
            sut.Handle(paymentRequest);

            // Assert
            sut.Invoking(x => x.Handle(paymentRequest)).Should().NotThrow<ArgumentException>();
        }

        [Fact]
        public void PhysicalpaymentRequestHandlerTest_WithMissingProductName_ShouldThrowArgumentException()
        {
            // Arrange
            var sut = new PhysicalPaymentRequestHandler();
            var paymentRequest = new PaymentRequest();

            // Act

            // Assert
            sut.Invoking(x => x.Handle(paymentRequest)).Should().Throw<ArgumentException>();
        }
    }
}
