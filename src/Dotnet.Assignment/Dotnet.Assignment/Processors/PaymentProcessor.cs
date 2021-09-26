using Dotnet.Assignment.UnitTests.Abstractions;
using Dotnet.Assignment.UnitTests.Models;

namespace Dotnet.Assignment.UnitTests.Processors
{
    public class PaymentProcessor
    {
        private IHandler<PaymentRequest> _handler;

        public PaymentProcessor(IHandler<PaymentRequest> handler)
        {
            _handler = handler;
        }

        public void Register(PaymentRequest paymentRequest)
        {
            _handler.Handle(paymentRequest);
        }
    }
}
