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
            var orderProccessor = new OrderProccessor();
            var bookOrderRequestHandler = new BookOrderRequestHandler();
            //bookOrderRequestHandler.SetNext(new PhysicalOrderRequestHandler()).SetNext()

            // Act
            orderProccessor.Register(bookOrderRequestHandler);

            // Assert

        }

    }

    public class OrderProccessor
    {
        public OrderProccessor()
        {
        }

        public void Register(BookOrderRequestHandler bookOrderRequestHandler)
        {
            throw new NotImplementedException();
        }
    }
}
