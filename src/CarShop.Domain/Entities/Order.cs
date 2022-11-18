using CarShop.Domain.EntitiesValidators;
using CarShop.Domain.Shared;
using FluentValidation.Results;

namespace CarShop.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Order() { }

        public Order(int personId, DateTime dateCreated, MethodOfPurchaseEnum methodofPurchase)
        {
            PersonId = personId;
            DateCreated = dateCreated;
            MethodofPurchase = methodofPurchase;
        }

        public int PersonId { get; set; }
        public DateTime DateCreated { get; set; }
        public MethodOfPurchaseEnum MethodofPurchase { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; private set; }

        public Order AddDetails(OrderDetails details)
        {
            if(OrderDetails == null)
                OrderDetails = new List<OrderDetails>();
            OrderDetails.Add(details);
            return this;
        }

        public Order SetPerson(int personId)
        {
            PersonId = personId;
            return this;
        }

        public override ValidationResult Validate() => new OrderValidators().Validate(this);
    }
}
