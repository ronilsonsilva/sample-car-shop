namespace CarShop.Shared.DTOs
{
    public class OrderDto : BaseDto
    {
        public int PersonId { get; set; }
        public DateTime DateCreated { get; set; }
        public MethodOfPurchaseEnumDto MethodofPurchase { get; set; }

        public ICollection<OrderDetailsDto> OrderDetails { get; private set; }
    }
}
