using CarShop.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarShop.Infra.Data.Context.Map
{
    internal class OrderDetailsMap : BaseMap<OrderDetails>
    {
        public OrderDetailsMap(string nomeTabela = "OrderDetails") : base(nomeTabela)
        {
        }

        public override void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId)
                .IsRequired();

            base.Configure(builder);
        }
    }
}
