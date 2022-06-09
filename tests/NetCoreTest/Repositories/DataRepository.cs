using NetCoreTest_test.Models;

namespace NetCoreTest_test.Repositories
{
    public class DataRepository
    {
        public T GetById<T>(int id) where T : BaseModel
        {
            return DbContext
                .Set<T>()
                .FirstOrDefault(model => model.Id == id);
        }

        public IEnumerable<T> GetByIds<T>(IEnumerable<int> ids) where T : BaseModel
        {
            return DbContext
                .Set<T>()
                .GetMany(model => ids.Contains(model.Id));
        }

        public IEnumerable<T> GetByCondition<T>(Func condition) where T : BaseModel
        {

        }
    }
}