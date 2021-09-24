using FluentAssertions;
using System;
using Xunit;

namespace Dotnet.Assignment
{
    public class PhysicalOrderRequestHandlerTest
    {
        //If the payment is for a physical product, generate a packing slip for shipping.
        [Fact]
        public void PhysicalOrderRequestHandlerTest_WithProductName_ShouldNotThrowExceptions()
        {
            // Arrange
            var sut = new PhysicalOrderRequestHandler();
            var orderRequest = new OrderRequest
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
            var sut = new PhysicalOrderRequestHandler();
            var orderRequest = new OrderRequest();

            // Act

            // Assert
            sut.Invoking(x => x.Handle(orderRequest)).Should().Throw<ArgumentException>();
        }
    }

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
        }
    }

    public class OrderRequest
    {
        public string ProductName { get; set; }
    }
}
