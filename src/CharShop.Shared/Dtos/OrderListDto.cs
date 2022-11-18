namespace CarShop.Shared.DTOs
{
    public class OrderListDto
    {
        public string CustomerFullName { get; set; }
        public int ProductId { get; set; }
        public int Age { get; set; }
        public int OrderId { get; set; }
        public DateTime DateCreated { get; set; }
        public MethodOfPurchaseEnumDto MethodofPurchase { get; set; }
        public string ProductNumber { get; set; }
        public string ProductOrigin { get; set; }
    }
}
