namespace Dotnet.Assignment.UnitTests.Models
{
    public class PaymentRequest
    {
        public string ProductName { get; set; }
        public ProductType ProductType { get; set; }
        public CategoryType? Category { get; set; }

        public bool IsVirtual => ProductType == ProductType.Virtual;
        // Something similar could be made with Category, where category 5-10 could be electronics, 11-17 could be toys etc.
    }

    // Some teams likes to have it as Exstensions methods, some don't.
    public static class PaymentRequestExstensions
    {
        public static bool IsPhysical(this PaymentRequest paymentRequest)
        {
            return paymentRequest.ProductType == ProductType.Physical;
        }
    }
}
