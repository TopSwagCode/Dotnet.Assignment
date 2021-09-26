namespace Dotnet.Assignment
{
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
}
