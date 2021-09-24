using FluentAssertions;
using System;
using Xunit;

namespace Dotnet.Assignment
{

    public class BookOrderRequestHandlerTests
    {
        //If the payment is for a physical product, generate a packing slip for shipping.
        [Fact]
        public void ProductWithTypeBook_ShouldBeHandledWhenCategoryIsProvided_ShouldNotThrowExceptions()
        {
            // Arrange
            var sut = new BookOrderRequestHandler();
            var orderRequest = new OrderRequest
            {
                ProductName = "Something awesome",
                ProductType = ProductType.Physical,
                Category = CategoryType.Book
            };

            // Act
            sut.Handle(orderRequest);

            // Assert
            sut.Invoking(x => x.Handle(orderRequest)).Should().NotThrow<ArgumentException>();
        }

        [Fact]
        public void WithMissingProductName_ShouldThrowArgumentException()
        {
            // Arrange
            var sut = new PhysicalOrderRequestHandler();
            var orderRequest = new OrderRequest();

            // Act

            // Assert
            sut.Invoking(x => x.Handle(orderRequest)).Should().Throw<ArgumentException>();
        }
    }
}
