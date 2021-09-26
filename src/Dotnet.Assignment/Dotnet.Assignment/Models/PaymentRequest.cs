namespace Dotnet.Assignment.UnitTests.Models
{
    public class PaymentRequest
    {
        public string ProductName { get; set; }
        public ProductType ProductType { get; internal set; }
        public CategoryType? Category { get; internal set; }
    }
}
