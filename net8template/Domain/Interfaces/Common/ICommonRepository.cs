namespace net8template.Domain.Interfaces.Common
{
    public interface ICommonRepository<TEntity, TId>
    {
        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> GetById(TId id);

        Task Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        Task Save();
    }
};
