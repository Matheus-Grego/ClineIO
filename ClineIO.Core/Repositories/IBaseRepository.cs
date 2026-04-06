namespace ClineIO.Core.Repositories;

public interface IBaseRepository<T> where T : class
{
    Task<List<T?>> GetAll(int pageNumber, int pageSize);
    Task<T?> GetById(Guid id);
    Task Add(T entity);
    Task Update(T entity);
}