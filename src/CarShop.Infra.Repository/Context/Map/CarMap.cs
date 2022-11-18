using CarShop.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarShop.Infra.Data.Context.Map
{

    internal class CarMap : BaseMap<Car>
    {
        public CarMap(string nomeTabela = "Car") : base(nomeTabela)
        {
        }

        public override void Configure(EntityTypeBuilder<Car> builder)
        {
            base.Configure(builder);
        }
    }
}
