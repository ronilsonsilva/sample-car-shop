using CarShop.Domain.EntitiesValidators;
using CarShop.Domain.Shared;
using FluentValidation.Results;

namespace CarShop.Domain.Entities
{
    public class OrderDetails : BaseEntity
    {
        protected OrderDetails() { }

        public OrderDetails(int orderId, int productId, string productNumber, string productOrigin)
        {
            OrderId = orderId;
            ProductId = productId;
            ProductNumber = productNumber;
            ProductOrigin = productOrigin;
        }

        public OrderDetails(int productId, string productNumber, string productOrigin)
        {
            ProductId = productId;
            ProductNumber = productNumber;
            ProductOrigin = productOrigin;
        }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductNumber { get; set; }
        public string ProductOrigin { get; set; }

        public Order Order { get; set; }

        public override ValidationResult Validate() => new OrderDetailsValidators().Validate(this);
    }
}
