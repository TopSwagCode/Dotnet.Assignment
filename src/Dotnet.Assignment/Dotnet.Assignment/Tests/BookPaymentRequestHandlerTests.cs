using Dotnet.Assignment.UnitTests.Handlers;
using Dotnet.Assignment.UnitTests.Models;
using FluentAssertions;
using System;
using Xunit;

namespace Dotnet.Assignment.UnitTests.Tests
{

    public class BookPaymentRequestHandlerTests
    {
        //If the payment is for a physical product, generate a packing slip for shipping.
        [Fact]
        public void ProductWithTypeBook_ShouldBeHandledWhenCategoryIsProvided_ShouldNotThrowExceptions()
        {
            // Arrange
            var sut = new BookPaymentRequestHandler();
            var paymentRequest = new PaymentRequest
            {
                ProductName = "Something awesome",
                ProductType = ProductType.Physical,
                Category = CategoryType.Book
            };

            // Act
            sut.Handle(paymentRequest);

            // Assert
            sut.Invoking(x => x.Handle(paymentRequest)).Should().NotThrow<ArgumentException>();
        }

        [Fact]
        public void WithMissingProductName_ShouldThrowArgumentException()
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
