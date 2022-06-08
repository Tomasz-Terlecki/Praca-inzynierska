using aspnet_core_test.Models;

namespace aspnet_core_test.Interfaces
{
    public interface IProportionScope
    {
        IDictionary<User, Proportion> UserProportion { get; set; }

        decimal GetProportionForUser(int userId);
        decimal GetProportionForAllUsersInScope();
    }
}