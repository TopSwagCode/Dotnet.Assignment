namespace Dotnet.Assignment
{
    public class OrderProcessor
    {
        private IHandler<PaymentRequest> _handler;

        public OrderProcessor(IHandler<PaymentRequest> handler)
        {
            _handler = handler;
        }

        public void Register(PaymentRequest paymentRequest)
        {
            _handler.Handle(paymentRequest);
        }
    }
}
