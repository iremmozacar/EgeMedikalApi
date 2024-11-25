namespace EgeApp.Backend.Entity.Concrete
{
    public class CartItem
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CartId { get; set; }
        // public Cart Cart { get; set; }
        public int Quantity { get; set; }
    }
}
