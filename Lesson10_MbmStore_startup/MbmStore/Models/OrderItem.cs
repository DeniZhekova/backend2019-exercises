namespace MbmStore.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public int InvoiceId { get; set; }

        public Product Product { get; set; }

        public OrderItem() { }
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal TotalPrice() { return Quantity * Product.Price; }
    }
}