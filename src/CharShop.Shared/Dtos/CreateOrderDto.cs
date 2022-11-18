

namespace CarShop.Shared.DTOs
{
    public class CreateOrderDto
    {
        public CustomerDto Customer { get; set; }
        public DateTime DateCreated { get; set; }
        public MethodOfPurchaseEnumDto MethodofPurchase { get; set; }

        public int CarId { get; set; }
    }


}
