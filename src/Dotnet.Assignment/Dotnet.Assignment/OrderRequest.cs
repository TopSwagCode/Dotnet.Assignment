namespace Dotnet.Assignment
{
    public class OrderRequest
    {
        public string ProductName { get; set; }
        public ProductType ProductType { get; internal set; }
        public CategoryType? Category { get; internal set; }
    }
}
