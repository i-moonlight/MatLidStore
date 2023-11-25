namespace MLS.Application.Contracts.Persistence.Common
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAll();

        Task<T> GetById(int id);

        Task Create(T entity);

        Task Update(T entity);

        Task Delete(T entity);
    }
}