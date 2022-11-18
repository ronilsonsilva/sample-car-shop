using CarShop.Domain.Entities;
using CarShop.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Infra.Data.Repositories
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(CarShopContext context) : base(context)
        {
        }

        public override async Task<IList<Order>> Get()
        {
            return await this._context.Set<Order>()
                .Include(x => x.OrderDetails)
                .ToListAsync();
        }
    }
}
