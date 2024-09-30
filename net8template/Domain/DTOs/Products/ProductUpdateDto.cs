
namespace net8template.Domain.DTOs.Products
{
    public class ProductUpdateDto
    {
        public int ProductId { get; set; }

        public string name { get; set; }

        public string? description { get; set; }

        public decimal price { get; set; }

        public int quantity { get; set; }
    }
};

