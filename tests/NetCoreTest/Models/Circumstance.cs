using NetCoreTest_test.Interfaces;

namespace NetCoreTest_test.Models
{
    public class Circumstance : IProportionScope
    {
        public IDictionary<User, Proportion> UserProportion { get; set; }

        public decimal CalculateExpenses()
        {
            throw new NotImplementedException();
        }

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