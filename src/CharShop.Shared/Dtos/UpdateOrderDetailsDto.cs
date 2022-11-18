namespace CarShop.Shared.DTOs
{
    public class UpdateOrderDetailsDto : OrderDetailsDto
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductOrigin { get; set; }
    }
}
