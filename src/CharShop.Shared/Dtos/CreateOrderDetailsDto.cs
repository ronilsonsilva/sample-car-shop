namespace CarShop.Shared.DTOs
{
    public class CreateOrderDetailsDto
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductOrigin { get; set; }
    }
}
