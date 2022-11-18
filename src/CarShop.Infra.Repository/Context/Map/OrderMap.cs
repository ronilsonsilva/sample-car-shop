using CarShop.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarShop.Infra.Data.Context.Map
{
    internal class OrderMap : BaseMap<Order>
    {
        public OrderMap(string nomeTabela = "Order") : base(nomeTabela)
        {
        }

        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
        }
    }
}
