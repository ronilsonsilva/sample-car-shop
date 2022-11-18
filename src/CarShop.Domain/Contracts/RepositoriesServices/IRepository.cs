using CarShop.Domain.Shared;

namespace CarShop.Domain.Contracts.RepositoriesServices
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<bool> Delete(int id);
        Task<TEntity> Get(int id);
        Task<IList<TEntity>> Get();
    }
}
