namespace BlazorBasics.Models
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public List<ProductProperty> ProductLists { get; set; } = new();
    }
}
