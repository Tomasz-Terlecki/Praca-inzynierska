using aspnet_core_test.Interfaces;

namespace aspnet_core_test.Models
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