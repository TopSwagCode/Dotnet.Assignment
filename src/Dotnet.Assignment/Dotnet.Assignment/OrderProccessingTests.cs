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

    // Idea for Abstraction
    // Have a abstract class with a Next handler.
    // Basic interface for setting Next, like AspNetCore uses AddUseRouting etc.
    // TODO: Implement interface for 2 existing Handlers and see how it would work.
    public abstract class Handler<T> : IHandler<T> where T : class
    {
        private IHandler<T> Next { get; set; }
        public virtual void Handle(T request)
        {
            Next?.Handle(request);
        }
        public IHandler<T> SetNext(IHandler<T> next)
        {
            Next = next;
            return Next;
        }
    }
    public interface IHandler<T> where T : class
    {
        IHandler<T> SetNext(IHandler<T> next);
        void Handle(T request);
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
