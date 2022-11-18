using CarShop.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarShop.Infra.Data.Context.Map
{
    internal class CustomerMap : BaseMap<Customer>
    {
        public CustomerMap(string nomeTabela = "Customer") : base(nomeTabela)
        {
        }

        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
        }
    }
}
