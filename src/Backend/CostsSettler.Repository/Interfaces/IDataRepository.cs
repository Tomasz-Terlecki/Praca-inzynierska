using CostsSettler.Model.Models;

namespace CostsSettler.Repository.Interfaces
{
    public interface IDataRepository
    {
        Task<T> GetByIdAsync<T>(long id, IEnumerable<string> includes = null)
            where T : BaseModel;

        Task<IEnumerable<T>> GetManyByConditionAsync<T>(
            Func<T, bool> condition = null,
            IEnumerable<string> includes = null
        ) where T : BaseModel;

        Task<T> AddAsync<T>(T model) where T : BaseModel;

        Task<IEnumerable<T>> AddRangeAsync<T>(IEnumerable<T> collection) where T : BaseModel;

        Task<T> UpdateAsync<T>(T model) where T : BaseModel;

        Task<T> RemoveAsync<T>(T model) where T : BaseModel;

        Task<IEnumerable<T>> RemoveRangeAsync<T>(IEnumerable<T> collection) where T : BaseModel;

        Task<bool> ContainsAsync<T>(T model) where T : BaseModel;

        Task<int> CountAsync<T>(Func<T, bool> condition = null) where T : BaseModel;
    }
}
