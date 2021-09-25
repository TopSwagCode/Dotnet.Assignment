using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Dotnet.Assignment
{
    public class OrderProccessingTests
    {
        [Fact]
        public void Test()
        {
            // Arrange
            var orderProccessor = new OrderProcessor();
            var bookOrderRequestHandler = new BookOrderRequestHandler();
            //bookOrderRequestHandler.SetNext(new PhysicalOrderRequestHandler()).SetNext()

            // Act
            orderProccessor.Register(bookOrderRequestHandler);

            // Assert

        }

    }

    public class OrderProcessor
    {
        public OrderProcessor()
        {
        }

        public void Register(BookOrderRequestHandler bookOrderRequestHandler)
        {
            bookOrderRequestHandler.Handle(orderRequest);
        }
    }
}
