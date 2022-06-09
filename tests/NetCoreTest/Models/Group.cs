using NetCoreTest_test.Interfaces;

namespace NetCoreTest_test.Models
{
    public class Group : IProportionScope
    {
        public IEnumerable<Circumstance> Circumstances { get; set; }
        public IDictionary<User, Proportion> UserProportion { get; set; }

        public decimal GetProportionForAllUsersInScope()
        {
            throw new NotImplementedException();
        }

        public decimal GetProportionForUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}