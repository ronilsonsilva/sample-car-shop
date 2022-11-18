namespace CarShop.Shared.DTOs
{
    public class OrderDetailsDto : BaseDto
    {
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductOrigin { get; set; }
    }
}
