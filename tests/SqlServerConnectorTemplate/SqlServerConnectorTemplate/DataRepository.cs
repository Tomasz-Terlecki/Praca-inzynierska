using Microsoft.EntityFrameworkCore;
using SqlServerConnectorTemplate.Models;

namespace SqlServerConnectorTemplate
{
    public class DataRepository
    {
        private readonly TestDbContext _dbContext;

        public DataRepository()
        {
            _dbContext = new TestDbContext();
        }

        public async Task<T> GetByIdAsync<T>(
            int id,
            IEnumerable<string> includes = null
        ) where T : BaseModel
        {
            var query = _dbContext.Set<T>().AsQueryable();

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include).AsQueryable();

            return await query.FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<IEnumerable<T>> GetManyByConditionAsync<T>(
            Func<T, bool> condition = null, 
            IEnumerable<string> includes = null
        ) where T : BaseModel
        {
            var query = _dbContext.Set<T>().AsQueryable();

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include).AsQueryable();

            if (condition != null)
                query = query.Where(condition).AsQueryable();

            return await query.ToListAsync();
        }

        public async Task<T> AddAsync<T>(T model) where T : BaseModel
        {
            var result = _dbContext.Set<T>().Add(model).Entity;

            await _dbContext.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<T>> AddRangeAsync<T>(IEnumerable<T> collection) where T : BaseModel
        {
            _dbContext.Set<T>().AddRange(collection);

            await _dbContext.SaveChangesAsync();

            return collection;
        }

        public async Task<T> UpdateAsync<T>(T model) where T : BaseModel
        {
            var result = _dbContext.Set<T>().Update(model).Entity;

            await _dbContext.SaveChangesAsync();

            return result;
        }

        public async Task<T> RemoveAsync<T>(T model) where T : BaseModel
        {
            var result = _dbContext.Set<T>().Remove(model).Entity;

            await _dbContext.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<T>> RemoveRangeAsync<T>(IEnumerable<T> collection) where T : BaseModel
        {
            _dbContext.Set<T>().RemoveRange(collection);

            await _dbContext.SaveChangesAsync();

            return collection;
        }

        public async Task<bool> ContainsAsync<T>(T model) where T : BaseModel
        {
            return await _dbContext.Set<T>().ContainsAsync(model);
        }

        public async Task<int> CountAsync<T>(Func<T, bool> condition = null) where T : BaseModel
        {
            return condition == null 
                ? await _dbContext.Set<T>().CountAsync()
                : _dbContext.Set<T>().Count(condition);
        }
    }
}